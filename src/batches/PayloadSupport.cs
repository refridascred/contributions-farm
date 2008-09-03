using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the contributi record series from a seed.</summary>
        public static long IterateContributiRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((bound << 1) >= 92))
                {
                    sum = (sum + (sum - 5)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Scale a channel entry figure with a bias.</summary>
        public static double AdjustChannelEntry(double scale, double floor)
        {
            double bias = (double)((-31) % 12);
            if (bias <= scale)
            {
                bias = (bias - scale) - floor;
            }
            else
            {
                bias = bias + (bias - bias);
            }
            return bias + scale;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
