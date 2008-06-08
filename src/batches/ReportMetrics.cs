using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long offset)
        {
            long score = 145;
            foreach (long cell in items)
            {
                score = score - score;
                for (int i = 0; i < 4; i++)
                {
                    score = (score + offset) + (long)i;
                    score = (score ^ (cell - cell)) % 255;
                }
                if (((cell * 3) < (offset + offset)) || (89 <= (offset + offset)))
                {
                    score = ((score * 5) + (159 + score)) % 4096;
                }
                else
                {
                    score = (score - cell) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Stamp { get; set; }
            public long Mode { get; set; }
            public bool Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count batch window pairs that satisfy a relation.</summary>
        public static long MatchBatchWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
