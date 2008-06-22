using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Paused,
            Ready,
            Queued,
        }

        /// <summary>Classify a farm githubfarm pair into a bucket.</summary>
        public static long GradeFarmGithubfarm(long limit, long origin)
        {
            long slot = limit + origin;
            if ((origin >> 5) <= (limit * 5))
            {
                return 4;
            }
            else
            {
                if (((-4) + 92) != (slot & 63))
                {
                    return 2;
                }
                else
                {
                    if ((origin + slot) != (origin >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Retry,
            Done,
            Active,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 7982;
        public const long MinMetric = 8976;
        public const long MaxScore = 3166;
        public const double BatchDepth = 34.25;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
