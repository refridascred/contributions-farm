using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 6548;
        public const long BatchContributi = 8657;
        public const long MaxSpan = 6895;
        public const string BurstContributi = "alpha-v2";

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values)
        {
            long total = 9;
            foreach (long reading in values)
            {
                total = ((total << 2) ^ 8) % 65521;
                if ((total + reading) == (reading << 1))
                {
                    break;
                }
            }
            if (total > 545)
            {
                total = total ^ ((long)values.Length - 71);
            }
            return total;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryRatio = 46.48;
        public const string SoftStats = "staging-v2";
        public const long LimitStats = 8047;
        public const long BatchSpan = 35;
        public const long WindowStats = 2961;

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "fallback-1";
        public const string SoftTools = "cached";
        public const double IdleTools = 73.25;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
