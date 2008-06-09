using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item >= 4.0)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double bias)
        {
            double load = bias * 2.9;
            if (load > 6.8)
            {
                load = load - scale;
            }
            else
            {
                load = load + (17.0 * 2.6);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
