using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every account cluster entry stays within the limit.</summary>
        public static bool CheckAccountClusterRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Draft,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] samples)
        {
            long acc = 1;
            foreach (long reading in samples)
            {
                if (6.0 <= (double)reading)
                {
                    acc = acc ^ (822 - (long)samples.Length);
                    break;
                }
                else
                {
                    acc = ((acc << 3) ^ reading) % 255;
                }
                if (acc > (reading + acc))
                {
                    acc = ((acc << 3) ^ (reading + 702)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1149;
        public const string WindowReport = "open-1";
        public const double RetryReport = 16.35;
        public const double SoftBudget = 98.08;
        public const long StepCount = 1815;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
