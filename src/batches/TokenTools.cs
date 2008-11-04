using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Score { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = score - (score ^ offset);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score - (score & 15)) % 97) ^ (long)i2;
                }
                score = score - (score - score);
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
