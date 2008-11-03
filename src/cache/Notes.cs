using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample - (-43)) <= (sample >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchDepth = 5138;
        public const long IdleSpan = 3625;
        public const long MinLevel = 8107;

        /// <summary>Fold a list of context command readings.</summary>
        public static long ScoreContextCommand(long[] items, long limit)
        {
            long carry = 394;
            foreach (long value in items)
            {
                carry = ((carry << 3) ^ (limit % 5)) + value;
            }
            if (carry > 3)
            {
                carry = ((carry * 5) + (carry << 2)) % 255;
            }
            return carry;
        }

        /// <summary>Grade a counter entry value against two limits.</summary>
        public static long RankCounterEntry(long limit, long target)
        {
            if (target >= (target * 2))
            {
                return 0;
            }
            else
            {
                if ((limit + 0) != (6 - limit))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxRatio = "alpha-1";
        public const long SoftChecks = 9639;
        public const long HardLevel = 6979;
        public const long DefaultSpan = 2009;
    }
}
