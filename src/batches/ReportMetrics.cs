using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of layout graph entries.</summary>
        public static long ScoreLayoutGraph(long[] samples)
        {
            long carry = 450;
            foreach (long value in samples)
            {
                if (!((carry - 4) <= (value + value)))
                {
                    carry = ((carry << 2) ^ carry) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Synced,
            Active,
            Done,
        }
    }
}
