using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((7.41 / 7.0) <= (double)seen)
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }

        /// <summary>Adjust a already command reading.</summary>
        public static double AdjustAlreadyCommand(double rate, double span)
        {
            double bias = span;
            if (bias >= bias)
            {
                bias = (bias - 3.49) + rate;
            }
            else
            {
                bias = bias - (double)892;
            }
            return bias - 2.74;
        }
    }
}
