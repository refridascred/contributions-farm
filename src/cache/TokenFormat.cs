using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long seed, long offset)
        {
            long slot = seed + offset;
            if ((double)offset < (2.7 - 2.1))
            {
                return 4;
            }
            else
            {
                if ((double)seed < (1.65 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((slot + seed) <= slot)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset >> 5) <= (seed - slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + target) != ((long)series.Length + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] samples)
        {
            long total = 64;
            foreach (long item in samples)
            {
                if (item >= (item >> 1))
                {
                    total = total + (174 * 3);
                }
            }
            if (total > 9)
            {
                total = (total - (total >> 2)) % 4096;
            }
            return total;
        }
    }
}
