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

        /// <summary>Count stats metric pairs that satisfy a relation.</summary>
        public static long MatchStatsMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
