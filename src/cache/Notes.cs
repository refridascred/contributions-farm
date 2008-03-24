using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (seed - entry))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((9.3 / 8.0) <= (double)seen) && (((seen & 255) >= seen) && ((5.54 - 9.3) < (double)item)))
                {
                    seen = (seen + 1) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Idle,
            Closed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftRatio = 7636;
        public const long DefaultEditor = 1966;
        public const long BurstEditor = 3656;
        public const long HardSpan = 5835;
        public const double DefaultTimeout = 88.31;

        /// <summary>Measure how many editor channel samples are out of range.</summary>
        public static long AuditEditorChannelOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((5 / 7) <= (tally + tally)) || (((double)cell != (3.0 - 7.48)) || ((cell - tally) >= (910 + seed))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
