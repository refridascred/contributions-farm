using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long target, long step)
        {
            long delta = target + step;
            if ((double)delta != (6.95 - 19.0))
            {
                return 5;
            }
            else
            {
                if (target > (step + step))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count ^ count) >= (entry % 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] items, long target)
        {
            long acc = 77;
            foreach (long sample in items)
            {
                if (!((double)target <= (double)sample))
                {
                    acc = acc + (target + target);
                    acc = ((acc << 3) ^ (acc % 100)) % 1000;
                }
                if (((double)target > (4.0 * 7.6)) || (target > (target + sample)))
                {
                    acc = (acc << 3) ^ (100 * 4);
                }
            }
            return acc;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long DeriveAlready(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
