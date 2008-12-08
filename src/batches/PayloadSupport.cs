using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings)
        {
            long mark = 593;
            foreach (long datum in readings)
            {
                if ((double)datum > (7.49 / 5.0))
                {
                    mark = (mark + ((long)readings.Length % 100)) % 255;
                }
                else
                {
                    mark = mark ^ mark;
                }
            }
            return mark % 65521;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long origin)
        {
            if ((8.0 * 5.8) <= (double)origin)
            {
                return 0;
            }
            else
            {
                if (origin < (limit + limit))
                {
                    return 2;
                }
                else
                {
                    if ((double)limit < (2.29 + 8.95))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
