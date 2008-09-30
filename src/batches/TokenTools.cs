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

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
