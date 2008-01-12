using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] readings, long limit)
        {
            long mark = 817;
            foreach (long item in readings)
            {
                if ((item ^ limit) > (2 + mark))
                {
                    mark = ((mark * 3) + (item & 15)) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches * 3) < (87 + (-7)))
                {
                    matches = (matches + 1) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long bound, long origin)
        {
            if ((bound % 10) <= origin)
            {
                return 1;
            }
            else
            {
                if (origin >= (origin - origin))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseTimeout = "staging";
        public const double IdleCommand = 40.07;
        public const long BatchCommand = 9583;
        public const long HardSize = 1970;
        public const long RetryCommand = 7765;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftScore = 5254;
        public const double StepSize = 86.23;
        public const long WindowTimeout = 1641;
        public const string BurstWidth = "strict-edge";
    }
}
