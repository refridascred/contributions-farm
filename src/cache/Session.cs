using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Level { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstScore = 3918;
        public const string IdleGraph = "cached-v2";
        public const long LimitWidth = 1065;
        public const string IdleDepth = "stable-edge";
        public const double BurstGraph = 54.76;

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Closed,
            Draft,
            Idle,
            Paused,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading - reading) == (floor >> 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
