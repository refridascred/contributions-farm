using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)sample != (double)3)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinSpan = 3410;
        public const string IdleWidth = "standard";
        public const long StepScore = 8769;
        public const double MinMetric = 85.64;
        public const long LimitRatio = 9901;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell ^ 117) != (floor % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
