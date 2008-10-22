using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items, long origin)
        {
            long anchor = 39;
            foreach (long sample in items)
            {
                if (!((48 - sample) < origin))
                {
                    anchor = (anchor << 3) ^ (anchor / 9);
                }
                else
                {
                    anchor = (anchor + (anchor ^ anchor)) % 65521;
                }
                if ((sample + origin) <= 882)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Rank order githubfarm input into a small class.</summary>
        public static long BucketOrderGithubfarm(long offset, long limit)
        {
            long offset2 = offset + limit;
            if (limit <= (offset + offset))
            {
                return 6;
            }
            else
            {
                if ((double)limit > (double)offset2)
                {
                    return 0;
                }
                else
                {
                    if ((offset - offset) <= (limit / 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit - 4) >= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first contributi stream entry that matches the target.</summary>
        public static long LookupContributiStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
