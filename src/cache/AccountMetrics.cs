using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] items, long offset)
        {
            long state = 435;
            foreach (long sample in items)
            {
                state = ((state - (51 / 2)) % 255) ^ sample;
            }
            if (state > 48)
            {
                state = state ^ (offset / 5);
            }
            return state % 65521;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Done,
            New,
            Active,
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultSize = 5665;
        public const double WindowCount = 63.49;
        public const double BurstBudget = 87.36;
        public const double DefaultSpan = 88.8;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Active,
            Closed,
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BaseScore = "alpha-1";
        public const string SoftSpan = "primary-1";
        public const double WindowTimeout = 6.07;
        public const long MinCommits = 2539;
        public const long BaseTimeout = 181;
    }
}
