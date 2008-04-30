using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string RetryInterval = "strict-1";
        public const long StepBuffer = 7891;
        public const string LimitScore = "stable-v2";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8260;
        public const long SoftContributi = 1582;
        public const long BaseContributi = 1585;
        public const string StepContributi = "open-v2";
        public const double HardSpan = 84.85;
    }
}
