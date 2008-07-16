using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum < 5.0)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double rate, double span)
        {
            double rate2 = span;
            if (rate2 > 4.3)
            {
                rate2 = rate2 + (rate - span);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - span) + (double)(long)i;
            }
            return rate2 + (span + rate2);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
