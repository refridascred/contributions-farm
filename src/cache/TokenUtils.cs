using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long step)
        {
            if ((offset + step) <= (offset ^ step))
            {
                return 3;
            }
            else
            {
                if (step >= 59)
                {
                    return 0;
                }
                else
                {
                    if ((offset & 127) <= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (step > (offset ^ offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank cache batch input into a small class.</summary>
        public static long RankCacheBatch(long floor, long floor2)
        {
            if ((19.0 - 2.2) <= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((12.0 + 9.34) >= (3.07 + 8.7))
                {
                    return 6;
                }
                else
                {
                    if ((floor << 2) < (floor << 1))
                    {
                        return 2;
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
