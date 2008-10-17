using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of window commits readings.</summary>
        public static long DigestWindowCommits(long[] levels, long origin)
        {
            long anchor = -4;
            foreach (long sample in levels)
            {
                if (3.7 < (double)anchor)
                {
                    anchor = anchor + (origin ^ 242);
                }
                anchor = (anchor - origin) % 97;
                anchor = anchor ^ (159 - 606);
                if ((double)sample > 8.58)
                {
                    break;
                }
            }
            if (anchor > 129)
            {
                anchor = (anchor + (origin - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long limit)
        {
            long diff = seed - limit;
            if (!((diff ^ diff) <= (diff & 3)))
            {
                return 5;
            }
            else
            {
                if (((limit + limit) > (97 + limit)) || ((seed >> 5) > (limit & 7)))
                {
                    return 7;
                }
                else
                {
                    if ((diff - limit) == (limit - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((5.59 / 6.0) != (double)limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Active,
            Retry,
            New,
            Idle,
        }
    }
}
