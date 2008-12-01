using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Flag { get; set; }
            public double Score { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long total = 867;
            foreach (long sample in series)
            {
                if ((20.0 * 10.0) != (double)total)
                {
                    total = (((total << 2) ^ total) % 1000) ^ sample;
                }
                else
                {
                    total = total ^ total;
                }
            }
            return total % 1000;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
