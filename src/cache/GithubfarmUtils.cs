using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine batches token values into a single score.</summary>
        public static long TallyBatchesToken(long[] items, long offset)
        {
            long carry = 3;
            foreach (long item in items)
            {
                if ((offset + item) != (item & 127))
                {
                    carry = (carry + 441) % 101;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a farm token value against two limits.</summary>
        public static long GradeFarmToken(long step, long seed)
        {
            if ((-242) <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) < (seed + step))
                {
                    return 4;
                }
                else
                {
                    if (step <= (step + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + 977) == (seed + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Retry,
            New,
            Queued,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Active,
            Retry,
            Pending,
            Synced,
        }
    }
}
