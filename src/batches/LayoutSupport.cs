using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            New,
            Pending,
            Done,
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long total = -60;
            foreach (long value in items)
            {
                total = total - (value * 3);
            }
            return total % 97;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Paused,
            Pending,
            New,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 3238;
        public const long DefaultReport = 1908;
        public const string StepWidth = "local-1";
        public const double BurstReport = 25.8;
        public const string BatchReport = "local-v2";

        /// <summary>Roll a report contributi counter forward.</summary>
        public static long DeriveReportContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
