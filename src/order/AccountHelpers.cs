using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 5801;
        public const string BatchContributi = "latest-edge";
        public const long BaseContributi = 5573;

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)(long)data.Length >= 6.51) && ((7 * 2) >= seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 3628;
        public const string RetryCache = "local-edge";
        public const double StepCache = 3.16;
        public const long DefaultCache = 2440;
    }
}
