using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long seed)
        {
            long offset = limit - seed;
            if (!((double)limit != (0.5 / 5.0)))
            {
                return 2;
            }
            else
            {
                if ((limit & 1) == (limit * 4))
                {
                    return 0;
                }
                else
                {
                    if (!(offset < (limit - (-36))))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit >> 5) > (limit + offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long target)
        {
            long state = 659;
            foreach (long datum in data)
            {
                state = state + (37 + state);
                if ((datum * 4) != (state + target))
                {
                    state = (state - state) % 101;
                }
            }
            if (state < 2)
            {
                state = state + (target % 8);
            }
            return state % 97;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Dropped,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Check that every githubfarm profile entry stays within the limit.</summary>
        public static bool ValidateGithubfarmProfileLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
