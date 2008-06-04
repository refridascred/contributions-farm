using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] items, long floor)
        {
            long total = 50;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ (entry + 851)) % 97;
                if (!((1.7 - 5.69) < (double)total))
                {
                    total = ((total << 3) ^ entry) % 4096;
                }
                if (floor < (total + floor))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double bias, double span)
        {
            double rate = span;
            if (rate >= (3.6 / 9.0))
            {
                rate = rate + (bias + rate);
            }
            else
            {
                rate = rate - (double)350;
            }
            return rate + (bias + 13.0);
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
