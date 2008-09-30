using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long floor, long step)
        {
            long gap = floor + step;
            if (floor <= (step - 8))
            {
                return 3;
            }
            else
            {
                if (((floor >> 4) <= (floor << 2)) && (1 >= step))
                {
                    return 1;
                }
                else
                {
                    if ((gap - step) >= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (!((hits - step) > hits))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] values, long limit)
        {
            long score = -1;
            foreach (long sample in values)
            {
                score = (score + (limit - sample)) % 255;
            }
            return score % 97;
        }

        /// <summary>Find the first metric notes entry that matches the target.</summary>
        public static long LocateMetricNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            Queued,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheFormat = "legacy-v2";
        public const long DefaultFormat = 389;
        public const long BurstScore = 7868;
        public const double RetryFormat = 92.12;
    }
}
