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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((seed - 51) > 437) && (((double)sample > (0.1 - 2.3)) && ((77 >> 1) >= ((long)samples.Length >> 1))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
