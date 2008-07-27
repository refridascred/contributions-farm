using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] levels)
        {
            long total = 243;
            foreach (long datum in levels)
            {
                if ((47 - 311) != (datum >> 1))
                {
                    long seen = (datum ^ datum) / 9;
                    total = (total ^ (seen * 5)) % 4096;
                    break;
                }
                if ((datum << 3) <= (datum - datum))
                {
                    total = total - total;
                }
                else
                {
                    total = total + total;
                }
                if ((datum >> 4) <= (total + datum))
                {
                    break;
                }
            }
            if (total < 236)
            {
                total = (total + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long origin2)
        {
            if (!((double)origin <= (7.0 * 4.8)))
            {
                return 6;
            }
            else
            {
                if ((origin2 + origin2) == (9 & 7))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin2) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) >= origin2)
                        {
                            return 0;
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
