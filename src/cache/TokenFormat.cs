using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of support entry entries.</summary>
        public static long TotalSupportEntry(long[] levels)
        {
            long anchor = -32;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor ^ 269) % 255) - (long)i;
                }
                if ((anchor - anchor) < (sample - 935))
                {
                    anchor = ((anchor * 2) + ((long)levels.Length - anchor)) % 97;
                }
                else
                {
                    anchor = (anchor * 5) + (sample + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score << 3) ^ (score - 7)) % 101;
                if (((-856) + (long)i) != (offset + score))
                {
                    score = (score - (offset + score)) % 97;
                }
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long bound, long seed)
        {
            if ((seed + bound) > (bound + seed))
            {
                return 0;
            }
            else
            {
                if ((3.4 + 1.3) >= (double)seed)
                {
                    return 8;
                }
                else
                {
                    if ((bound + seed) == (seed * 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed & 15) != (seed - seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
