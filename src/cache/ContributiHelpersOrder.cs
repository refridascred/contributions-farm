using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 9232;
        public const double MaxChecks = 44.75;
        public const long DefaultTimeout = 7988;
        public const long SoftSize = 9767;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long offset)
        {
            if ((4.0 + 1.5) == (double)target)
            {
                return 2;
            }
            else
            {
                if ((offset * 4) >= (target >> 5))
                {
                    return 8;
                }
                else
                {
                    if ((offset > (target * 5)) && ((target + target) == (307 - target)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double scale2 = scale;
            if (scale2 < scale)
            {
                scale2 = scale2 + (scale - 2.4);
            }
            else
            {
                scale2 = scale2 + span;
            }
            return scale2 + (double)(-371);
        }
    }
}
