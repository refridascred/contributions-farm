using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long carry = 84;
            foreach (long item in readings)
            {
                carry = ((carry - step) % 1000) ^ item;
            }
            return carry % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "strict-1";
        public const string HardWindow = "local";
        public const string CacheScore = "alpha-v2";
        public const double HardLevel = 43.39;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Done,
            Locked,
            Retry,
        }
    }
}
