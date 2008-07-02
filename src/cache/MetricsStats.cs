using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Size { get; set; }
            public double Ratio { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((807 ^ count) != (datum & 127))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstSize = 1780;
        public const long BurstWidth = 8890;
        public const double RetryLevel = 90.2;
        public const string LimitStream = "strict-v2";
    }
}
