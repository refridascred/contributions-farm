using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitScore = 5927;
        public const long BaseAccount = 2596;
        public const double MaxBudget = 70.18;

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long target)
        {
            long slot = step ^ target;
            if (((step * 3) != (target + 52)) && ((15.0 * 3.0) == (double)step))
            {
                return 4;
            }
            else
            {
                if (slot >= (step + 444))
                {
                    return 6;
                }
                else
                {
                    if (((target * 4) != (target / 5)) || ((target + slot) > slot))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target >> 1) < (step << 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
