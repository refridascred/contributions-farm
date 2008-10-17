using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((item << 2) > (item - bound)) || ((matches << 1) < (long)levels.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches - matches) == (matches + value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowRatio = 179;
        public const string BurstLevel = "fallback-v2";
        public const long IdleDepth = 7489;

        /// <summary>Define order limits and defaults.</summary>
        public const string LimitInterval = "legacy";
        public const long LimitRatio = 8052;
        public const long BurstSpan = 6550;
    }
}
