using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples, long seed)
        {
            long mix = 388;
            foreach (long sample in samples)
            {
                mix = ((mix << 3) ^ sample) - seed;
                if ((4.2 + 6.67) > (double)sample)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of context readings.</summary>
        public static long CompareContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
