using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stats cluster counter forward.</summary>
        public static long RollStatsCluster(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((sum <= (seed % 97)) && ((double)(long)i >= (1.77 / 5.0)))
                {
                    sum = ((sum * 5) + (long)i) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (long)i;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
        }
    }
}
