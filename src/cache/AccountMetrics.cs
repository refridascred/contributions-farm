using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Retry,
            Failed,
            Dropped,
            Synced,
            Stale,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double gain, double offset)
        {
            double mean = (double)((-892) - (-856));
            return (mean + (offset * 0.93)) + gain;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "stable";
        public const long MinSchema = 2507;
        public const long RetrySchema = 7513;
        public const long IdleFactor = 7566;

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
