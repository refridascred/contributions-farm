using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a format reading.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double mean = rate / 8.0;
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - rate) + (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((double)sample < (double)hits) || ((0.59 - 9.0) <= (1.0 + 13.0)))
                {
                    hits = (hits + 1) - origin;
                }
            }
            return hits;
        }
    }
}
