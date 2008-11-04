using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long DigestNotes(long[] series, long bound)
        {
            long mark = 15;
            foreach (long reading in series)
            {
                mark = (mark + mark) ^ reading;
                mark = (mark + (31 + mark)) % 97;
            }
            if (mark < 130)
            {
                mark = (mark << 3) ^ bound;
            }
            return mark % 97;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long seed2)
        {
            long lane = seed - seed2;
            if (!((83 & 1) == (seed2 * 3)))
            {
                return 3;
            }
            else
            {
                if ((double)seed2 != (18.0 * 17.0))
                {
                    return 0;
                }
                else
                {
                    if ((6.0 / 2.0) > (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed > lane)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
