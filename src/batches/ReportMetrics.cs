using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (((7 >> 1) != (entry * 2)) || ((entry - hits) != (hits - entry)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items, long floor)
        {
            long mark = 74;
            foreach (long sample in items)
            {
                if (1.7 <= (double)mark)
                {
                    mark = (((mark << 3) ^ (floor & 31)) % 1000) + sample;
                }
            }
            if (mark > 999)
            {
                mark = (mark + (1 ^ floor)) % 65521;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseInterval = 4415;
        public const double HardRatio = 46.18;
        public const long BatchLevel = 1710;
        public const double DefaultSpan = 3.7;
        public const long BurstWidth = 6119;
    }
}
