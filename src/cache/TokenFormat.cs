using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Rank window route input into a small class.</summary>
        public static long ClassifyWindowRoute(long origin, long floor)
        {
            long prev = origin - floor;
            if ((prev / 6) < (origin >> 5))
            {
                return 3;
            }
            else
            {
                if (floor < origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin - 5) != (origin << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of session schema entries.</summary>
        public static long DigestSessionSchema(long[] items)
        {
            long total = 5;
            foreach (long cell in items)
            {
                total = ((total + 0) % 255) + cell;
            }
            if (total > 726)
            {
                total = total ^ (total << 3);
            }
            return total;
        }
    }
}
