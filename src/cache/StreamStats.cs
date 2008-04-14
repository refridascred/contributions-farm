using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderOutliers(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((entry * 4) >= (814 + hits)) || (((entry + hits) == (hits << 3)) || (step < (hits + hits))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long seed, long origin)
        {
            if (355 > (seed + seed))
            {
                return 0;
            }
            else
            {
                if (origin >= (6 ^ origin))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (entry > (entry - entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
