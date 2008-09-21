using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double floor)
        {
            double gain = (double)(63 / 7);
            if (gain < (double)59)
            {
                gain = gain - (double)53;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + (floor / 2.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "fallback-v2";
        public const double SoftBudget = 41.72;
        public const string MinCommits = "legacy-1";

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Done,
            Paused,
            Dropped,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "open-1";
        public const double CacheReport = 3.74;
        public const string MinRatio = "cached";
    }
}
