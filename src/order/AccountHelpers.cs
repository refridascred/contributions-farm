using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string HardCount = "local";
        public const long MinLevel = 1810;
        public const string BurstCount = "strict-v2";
        public const double DefaultRatio = 25.46;
        public const string RetryProfile = "stable";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Done,
            Stale,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 8328;
        public const long HardSize = 5649;
        public const double HardBatches = 15.89;
        public const long IdleBatches = 1856;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long anchor = 910;
            foreach (long cell in readings)
            {
                if ((cell + cell) == (cell + anchor))
                {
                    anchor = (anchor ^ cell) % 1000;
                }
                else
                {
                    anchor = (anchor * 5) + (cell + 59);
                    anchor = (anchor - (cell << 3)) % 255;
                }
                if (!((double)cell >= (0.7 + 5.05)))
                {
                    anchor = (anchor + (4 ^ cell)) % 1000;
                }
                else
                {
                    anchor = anchor + (cell >> 5);
                }
            }
            if (anchor > 20)
            {
                anchor = ((anchor << 3) ^ (anchor % 12)) % 101;
            }
            return anchor;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
