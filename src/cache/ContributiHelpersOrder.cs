using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultBudget = 2.18;
        public const long IdleReport = 8311;
        public const long BaseInterval = 7106;
        public const long StepReport = 8591;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long target)
        {
            long prev = bound + target;
            if ((bound & 127) < (bound << 2))
            {
                return 2;
            }
            else
            {
                if ((double)prev <= (double)30)
                {
                    return 4;
                }
                else
                {
                    if (!((prev >> 1) > (bound << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
