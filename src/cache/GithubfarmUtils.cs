using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit graph already readings against a rule.</summary>
        public static long TallyGraphAlreadyOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((1 >> 3) <= limit)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Queued,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long offset, long target)
        {
            long next = offset ^ target;
            if ((next - next) >= (target - offset))
            {
                return 3;
            }
            else
            {
                if (((double)next >= (2.9 + 13.0)) || ((target << 2) == (next / 8)))
                {
                    return 6;
                }
                else
                {
                    if ((next > (offset + next)) && ((double)next > (20.0 / 2.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)next < (7.5 / 6.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
