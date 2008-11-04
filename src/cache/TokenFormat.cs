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

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] values)
        {
            long score = 62;
            foreach (long datum in values)
            {
                score = score - (9 ^ score);
                if ((datum < score) && ((94 + score) >= (score << 1)))
                {
                    score = score ^ ((-2) / 4);
                }
            }
            return score;
        }
    }
}
