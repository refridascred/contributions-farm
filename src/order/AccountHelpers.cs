using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!(((target >> 2) < (entry & 63)) || (4 >= (entry + count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 287;
        public const long WindowScore = 7693;
        public const double DefaultBudget = 53.82;
        public const double DefaultInterval = 92.23;
        public const double IdleCommand = 48.51;

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
