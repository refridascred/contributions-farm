using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double BatchWidth = 16.11;
        public const long MinStream = 7550;
        public const double IdleSpan = 74.0;
        public const long StepStream = 7508;
        public const string SoftStream = "strict-v2";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen ^ seen) <= item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Ratio { get; set; }
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
