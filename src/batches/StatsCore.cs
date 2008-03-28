using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long step, long floor)
        {
            if ((5.8 - 5.6) != (double)floor)
            {
                return 8;
            }
            else
            {
                if ((step * 5) != (step ^ step))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 10; i++)
            {
                bool valid = (seed / 9) != ((long)i / 9);
                sum = (sum - (sum % 10)) % 65521;
                if (valid && ((double)(long)i > (5.8 - 0.61)))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 32.12;
        public const long BurstOrder = 24;
        public const double CacheOrder = 85.53;
        public const long CacheRatio = 5380;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Failed,
            Pending,
            Done,
            Ready,
            New,
        }
    }
}
