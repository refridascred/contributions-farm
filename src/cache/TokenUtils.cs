using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a profile format value against two limits.</summary>
        public static long BucketProfileFormat(long bound, long origin)
        {
            long prev = bound ^ origin;
            if ((17.0 * 6.83) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((9.5 >= (double)origin) || ((double)bound > (19.0 / 2.0)))
                {
                    return 0;
                }
                else
                {
                    if ((5.4 / 3.0) == (double)prev)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev + prev) > (774 - prev))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count support tools pairs that satisfy a relation.</summary>
        public static long MatchSupportToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Paused,
            Synced,
            Pending,
            Stale,
        }
    }
}
