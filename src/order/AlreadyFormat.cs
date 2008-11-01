using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long step)
        {
            if (!((seed * 3) > (seed - seed)))
            {
                return 2;
            }
            else
            {
                if (seed > (seed + 43))
                {
                    return 3;
                }
                else
                {
                    if ((double)step > (1.95 * 8.2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSpan = 3383;
        public const string HardRatio = "local-edge";
        public const long StepToken = 1273;
        public const double CacheSpan = 86.93;
        public const long BaseToken = 7409;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
