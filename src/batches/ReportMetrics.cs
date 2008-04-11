using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long CountCommitsRecordGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum > (seen >> 4))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items)
        {
            long anchor = -62;
            foreach (long cell in items)
            {
                if (!(cell <= (cell >> 4)))
                {
                    anchor = (anchor - cell) % 255;
                }
                anchor = anchor ^ (8 * 5);
            }
            return anchor;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Dropped,
            Idle,
        }
    }
}
