using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item ^ 75) >= (matches % 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((sample + 8) >= (total - total))
                {
                    total = (total ^ (3 << 3)) - target;
                }
            }
            return total % 1000;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string StepBatches = "open-v2";
        public const long HardFactor = 9067;
        public const long BaseWidth = 7471;
        public const long StepSpan = 3299;
        public const long MinSpan = 6635;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            New,
            Draft,
            Ready,
            Queued,
        }
    }
}
