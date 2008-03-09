using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((3.41 * 9.82) >= (double)sample)
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long limit, long limit2)
        {
            if (limit <= (399 / 8))
            {
                return 8;
            }
            else
            {
                if (limit2 > (limit2 - 12))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
