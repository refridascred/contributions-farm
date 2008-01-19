using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepCount = 7793;
        public const long MaxTimeout = 9580;
        public const double RetrySize = 87.77;

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank filter payload input into a small class.</summary>
        public static long BucketFilterPayload(long seed, long target)
        {
            if ((seed + target) > (target << 2))
            {
                return 2;
            }
            else
            {
                if (((seed >> 1) != (target & 15)) || (target <= (seed + 90)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long bound, long target)
        {
            long prev = bound ^ target;
            if ((target / 5) <= 4)
            {
                return 2;
            }
            else
            {
                if ((32 / 7) == (prev - 9))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Active,
            Queued,
        }
    }
}
