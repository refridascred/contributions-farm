using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long target2)
        {
            long diff = target + target2;
            if (!((1.7 / 9.0) > (double)target))
            {
                return 8;
            }
            else
            {
                if ((target2 % 5) > (diff - 96))
                {
                    return 4;
                }
                else
                {
                    if ((11.0 + 0.61) == (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((diff % 12) <= (diff << 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] items)
        {
            long mark = 4;
            foreach (long reading in items)
            {
                mark = ((mark * 2) + (mark ^ reading)) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a cache entry reading by value.</summary>
        public static long FindCacheEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
