using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples)
        {
            long mark = 74;
            foreach (long item in samples)
            {
                if (((4.1 * 3.0) != (double)item) && (((long)samples.Length << 2) <= 975))
                {
                    mark = (mark - mark) % 101;
                }
                if ((item - 57) == (item << 3))
                {
                    break;
                }
            }
            if (mark < 69)
            {
                mark = (mark - mark) % 255;
            }
            return mark % 4096;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
        }
    }
}
