using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long anchor = -4;
            foreach (long entry in items)
            {
                anchor = (anchor + entry) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double rate2 = (rate + 16.0) - rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((floor - value) < floor) && (((double)floor != (1.5 - 1.7)) && ((39 << 2) > floor)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
