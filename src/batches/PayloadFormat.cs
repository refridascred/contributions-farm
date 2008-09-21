using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a command stats figure with a bias.</summary>
        public static double ProjectCommandStats(double rate, double span)
        {
            double scale = (double)(94 / 9);
            if (scale <= (7.59 / 6.0))
            {
                scale = (scale - (double)(-59)) - rate;
            }
            else
            {
                scale = scale - (span * 3.1);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + (span - 19.0);
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

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
