using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double IdleSpan = 32.5;
        public const long WindowContext = 1503;
        public const long MinBudget = 5255;
        public const string StepRatio = "standard-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] samples)
        {
            long mix = 6;
            foreach (long reading in samples)
            {
                mix = (mix + (reading * 5)) % 255;
                mix = (mix - (reading & 63)) % 1000;
            }
            return mix;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
