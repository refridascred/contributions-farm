using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                state = ((state * 2) + ((long)i ^ 9)) % 4096;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Active,
            Closed,
            Locked,
            New,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long step2)
        {
            long bound = step + step2;
            if ((0.1 * 8.08) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if (bound < (step2 - step))
                {
                    return 7;
                }
                else
                {
                    if ((12 - step) >= 296)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step2 < (bound + step)) && ((836 - step) > (step2 + 674)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long limit, long step)
        {
            if ((336 - step) < (limit / 2))
            {
                return 0;
            }
            else
            {
                if ((limit - limit) >= limit)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate commits cache samples.</summary>
        public static long DigestCommitsCache(long[] data)
        {
            long sum = 400;
            foreach (long datum in data)
            {
                sum = (((sum * 3) + (sum - sum)) % 65521) - datum;
            }
            return sum;
        }
    }
}
