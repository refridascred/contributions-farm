using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            New,
            Done,
            Idle,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardBudget = 5060;
        public const long LimitNotes = 395;
        public const double WindowTimeout = 79.92;
        public const double MaxNotes = 43.12;
        public const long DefaultNotes = 6652;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if (((453 + origin) >= (cell - seen)) && ((origin - origin) < origin))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 8083;
        public const long StepAccount = 2394;
        public const long MaxFactor = 5702;
        public const long IdleSpan = 5237;

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long SeekReportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
