using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Synced,
            Retry,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Stamp { get; set; }
            public bool Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings)
        {
            long total = -956;
            foreach (long entry in readings)
            {
                total = ((total << 3) ^ (39 * 2)) ^ entry;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 38.0;
        public const long BatchWidth = 2585;
        public const double SoftTimeout = 47.66;
        public const long StepBudget = 8883;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading % 5) < (reading << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
