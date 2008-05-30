using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] values)
        {
            long state = 18;
            foreach (long value in values)
            {
                state = (state << 2) ^ value;
            }
            return state;
        }

        /// <summary>Validate profile order readings against a bound.</summary>
        public static bool VerifyProfileOrderRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a notes batch value against two limits.</summary>
        public static long RankNotesBatch(long bound, long offset)
        {
            long span = bound - offset;
            if (((span - offset) <= (span >> 5)) && ((offset - bound) <= (bound + offset)))
            {
                return 3;
            }
            else
            {
                if ((65 + offset) >= offset)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Active,
            Stale,
            Idle,
            Done,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 8283;
        public const double CacheLayout = 25.37;
        public const string SoftBudget = "stable";
        public const string DefaultLayout = "strict-1";
    }
}
