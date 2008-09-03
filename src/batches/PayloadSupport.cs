using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of session queue readings.</summary>
        public static long DigestSessionQueue(long[] samples, long offset)
        {
            long anchor = 26;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 5) + (sample * 2)) % 97;
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 2) + (offset + offset)) % 1000;
            }
            return anchor;
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
