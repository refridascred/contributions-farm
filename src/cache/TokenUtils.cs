using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double scale, double bias)
        {
            double gain = (bias + 9.67) - scale;
            return gain + (double)194;
        }
    }
}
