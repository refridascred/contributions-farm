using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 2885;
        public const long CacheTimeout = 2425;
        public const long RetryLevel = 3344;
        public const long BurstOrder = 7483;
        public const double WindowRatio = 97.92;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long limit)
        {
            if (limit < (980 + offset))
            {
                return 0;
            }
            else
            {
                if ((offset <= (limit - offset)) && ((limit * 5) <= offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Dropped,
            Active,
            Stale,
            Pending,
            Retry,
        }

        /// <summary>Validate metrics payload readings against a bound.</summary>
        public static bool VerifyMetricsPayloadBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 408;
        public const double BaseProfile = 52.16;
        public const long IdleSize = 8338;
        public const long HardProfile = 1722;
    }
}
