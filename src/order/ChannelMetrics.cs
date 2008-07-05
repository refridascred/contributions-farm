using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((matches * 5) > 2)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long datum in readings)
            {
                mark = ((mark - (floor & 127)) % 97) + datum;
            }
            if (mark < (-9))
            {
                mark = (mark + (2 / 7)) % 4096;
            }
            return mark;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((entry * 5) > entry)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
