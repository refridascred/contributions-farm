using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a buffer layout value against two limits.</summary>
        public static long SortBufferLayout(long step, long target)
        {
            long delta = step ^ target;
            if (((step + 955) == (step - delta)) || ((step - target) > 74))
            {
                return 0;
            }
            else
            {
                if ((delta / 2) <= (delta - target))
                {
                    return 8;
                }
                else
                {
                    if ((7.0 - 3.77) < (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 93.48;
        public const long MaxRecord = 9413;
        public const double IdleRecord = 76.3;
        public const long RetryRecord = 7442;
    }
}
