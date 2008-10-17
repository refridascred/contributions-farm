using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Locked,
            Synced,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "open-1";
        public const long DefaultBudget = 8877;
        public const long MinContributi = 8158;
        public const double MaxRatio = 70.19;

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long step, long seed)
        {
            long cur = step ^ seed;
            if ((seed - cur) >= (step + seed))
            {
                return 4;
            }
            else
            {
                if ((double)step >= 4.0)
                {
                    return 8;
                }
                else
                {
                    if (!((82 + seed) == (step + seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Failed,
            Dropped,
            Pending,
            New,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
