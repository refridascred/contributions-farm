using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (2.33 <= (double)count)
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
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
