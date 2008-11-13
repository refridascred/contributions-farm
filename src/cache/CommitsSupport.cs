using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long limit)
        {
            if ((offset + 63) >= (offset - limit))
            {
                return 7;
            }
            else
            {
                if ((offset >> 2) > limit)
                {
                    return 0;
                }
                else
                {
                    if ((9.0 / 9.0) > (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if (90 >= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Dropped,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Retry,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] values)
        {
            long sum = -70;
            foreach (long item in values)
            {
                sum = ((sum << 2) ^ (item + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Match up counter schema samples.</summary>
        public static long MatchCounterSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Dropped,
            New,
            Paused,
        }
    }
}
