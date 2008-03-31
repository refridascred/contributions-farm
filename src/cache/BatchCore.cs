using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((4.1 / 7.0) < (double)acc)
                {
                    break;
                }
                else
                {
                    acc = acc + ((long)i + acc);
                }
                acc = acc - ((long)i + acc);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Rank queue contributi input into a small class.</summary>
        public static long ClassifyQueueContributi(long limit, long floor)
        {
            if ((floor + limit) == (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if ((floor * 5) <= (limit + 0))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Closed,
            Synced,
            New,
            Draft,
            Ready,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Queued,
            Pending,
            New,
            Paused,
        }
    }
}
