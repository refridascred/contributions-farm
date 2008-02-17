using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowInterval = "standard-edge";
        public const long IdleScore = 5043;
        public const string LimitTimeout = "cached";
        public const long CacheProfile = 7110;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((728 / 5) < (seen - (long)levels.Length))
                {
                    seen = ((seen + 3) ^ reading) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
