using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long floor)
        {
            long cur = origin - floor;
            if ((double)cur >= 12.0)
            {
                return 5;
            }
            else
            {
                if ((cur < origin) || ((floor + origin) > origin))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] samples, long offset)
        {
            long carry = 622;
            foreach (long item in samples)
            {
                if (offset >= (4 * 4))
                {
                    carry = ((carry ^ (50 * 5)) % 1000) ^ item;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                if (entry > (sum * 3))
                {
                    sum = ((sum * 2) + (sum ^ 7)) % 65521;
                }
                else
                {
                    sum = sum - (entry - sum);
                }
            }
            if (sum > 83)
            {
                sum = sum ^ (sum ^ 7);
            }
            return sum % 65521;
        }

        /// <summary>Combine cluster format values into a single score.</summary>
        public static long FoldClusterFormat(long[] levels)
        {
            long state = 434;
            foreach (long entry in levels)
            {
                if ((39 ^ entry) >= entry)
                {
                    state = (state + (state & 1)) % 65521;
                }
            }
            if (state > 420)
            {
                state = (state << 3) ^ (state + state);
            }
            return state % 4096;
        }
    }
}
