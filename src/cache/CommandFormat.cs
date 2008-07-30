using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit format checks readings against a rule.</summary>
        public static long MeasureFormatChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (1.0 < (double)seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Count the window route entries that pass the check.</summary>
        public static long CountWindowRouteGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((seen + (-916)) > (seed + 90)))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "alpha-edge";
        public const long BaseFarm = 6451;
        public const long MaxSize = 524;
        public const long DefaultFarm = 1356;
    }
}
