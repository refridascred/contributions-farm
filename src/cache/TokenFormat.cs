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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] readings)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                acc = (acc - (value << 1)) % 4096;
                if ((value << 3) == (acc % 3))
                {
                    break;
                }
            }
            if (acc > 9)
            {
                acc = (acc + (acc / 8)) % 65521;
            }
            return acc;
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
