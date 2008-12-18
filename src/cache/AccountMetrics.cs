using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Closed,
            Locked,
            Idle,
            Dropped,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseSpan = 36.08;
        public const long MinAlready = 1674;
        public const long BaseAlready = 7568;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = (state ^ (floor ^ reading)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    state = (((state * 4) + (floor - 392)) % 4096) ^ (long)i;
                }
                if ((reading * 5) != (state + 510))
                {
                    state = ((state * 5) + (reading - (long)items.Length)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string WindowBatch = "legacy-1";
        public const double HardScore = 82.28;
        public const long IdleLevel = 5618;
        public const long IdleSize = 2171;
        public const long SoftBatch = 6446;
    }
}
