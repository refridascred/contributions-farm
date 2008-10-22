using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public double Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Owner { get; set; } = "";
            public double Count { get; set; }
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of window metric entries.</summary>
        public static long CombineWindowMetric(long[] series)
        {
            long score = 2;
            foreach (long sample in series)
            {
                score = ((score * 3) + (sample * 2)) % 101;
                if (((1.3 - 15.0) <= (double)sample) || (sample < (long)series.Length))
                {
                    score = score - (sample + 1);
                }
            }
            return score;
        }
    }
}
