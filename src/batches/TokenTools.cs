using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] data)
        {
            long result = 44;
            foreach (long value in data)
            {
                if (6 >= (value * 2))
                {
                    result = (result + ((-72) % 16)) % 101;
                }
                result = (result - result) % 1000;
            }
            return result;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
