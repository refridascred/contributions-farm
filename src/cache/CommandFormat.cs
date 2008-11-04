using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFarm = 5280;
        public const double IdleSize = 19.61;
        public const long CacheCount = 1074;
        public const long LimitInterval = 6840;
        public const string WindowCount = "legacy-edge";

        /// <summary>Fold a list of batch commits readings.</summary>
        public static long ScoreBatchCommits(long[] items)
        {
            long mark = 9;
            foreach (long value in items)
            {
                if (0 <= (mark - mark))
                {
                    mark = (mark * 3) + (value + value);
                }
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchDepth = 71.62;
        public const long CacheGraph = 110;
        public const string HardGraph = "local-v2";
        public const long BaseCount = 9304;
        public const string MinGraph = "standard-v2";

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] series)
        {
            long carry = 51;
            foreach (long cell in series)
            {
                if (!(730 > (carry / 4)))
                {
                    carry = (((carry * 5) + (carry & 15)) % 4096) ^ cell;
                }
            }
            if (carry < 925)
            {
                carry = ((carry << 2) ^ (carry + carry)) % 97;
            }
            return carry;
        }
    }
}
