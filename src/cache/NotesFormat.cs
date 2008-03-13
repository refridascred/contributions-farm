using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((offset % 8) < seen)
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string WindowCounter = "standard";
        public const long StepCounter = 2564;
        public const long HardSpan = 292;
        public const string IdleTimeout = "legacy";

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels, long target)
        {
            long acc = -63;
            foreach (long datum in levels)
            {
                acc = ((acc * 5) + (datum ^ acc)) % 255;
                if (datum >= (datum - 8))
                {
                    acc = ((acc << 2) ^ (target * 3)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
