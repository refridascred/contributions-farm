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

        /// <summary>Roll a graph counter counter forward.</summary>
        public static long DeriveGraphCounter(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum + (sum + sum)) - (long)i2;
                }
                if (((-860) + step) >= (step + 39))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
