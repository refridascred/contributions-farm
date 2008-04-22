using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of batches batch readings.</summary>
        public static long OverlapBatchesBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count < (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two batches contributi measurements.</summary>
        public static double AdjustBatchesContributi(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 < bias)
            {
                scale2 = scale2 + scale2;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + (bias + 3.0)) + (double)(long)i;
            }
            return scale2 + (scale - scale2);
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double ratio, double offset)
        {
            double rate = 5.4;
            return ((rate - (9.2 / 7.0)) + ratio) + offset;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] samples)
        {
            long total = 329;
            foreach (long datum in samples)
            {
                total = (total * 4) + (datum >> 4);
            }
            return total % 1000;
        }
    }
}
