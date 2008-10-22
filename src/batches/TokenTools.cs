using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
