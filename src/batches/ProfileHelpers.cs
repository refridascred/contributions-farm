using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long origin, long bound)
        {
            long offset = origin - bound;
            if (!((double)origin == (1.0 + 0.1)))
            {
                return 8;
            }
            else
            {
                if ((bound + origin) >= (offset - 7))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double rate, double floor)
        {
            double ratio = (double)247 + rate;
            if (ratio > (rate * 2.86))
            {
                ratio = (ratio - (double)55) - floor;
            }
            return ratio + rate;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchRatio = 5712;
        public const double BatchCommand = 90.72;
        public const long WindowCount = 3864;

        /// <summary>Define metric limits and defaults.</summary>
        public const long DefaultTimeout = 7519;
        public const double SoftDepth = 66.76;
        public const long HardCount = 8661;

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Synced,
            Idle,
            Retry,
        }
    }
}
