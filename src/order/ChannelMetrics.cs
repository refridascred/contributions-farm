using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((-1) * 3) < (value % 12))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] items)
        {
            long result = 8;
            foreach (long item in items)
            {
                result = (((result * 2) + result) % 97) - item;
            }
            if (result > 70)
            {
                result = (result + (result + 377)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TotalMetricEditor(long[] data)
        {
            long anchor = -853;
            foreach (long reading in data)
            {
                if ((88 / 7) <= (anchor * 5))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor - (anchor % 5)) % 65521) + reading;
                }
                anchor = (anchor + (anchor >> 4)) % 1000;
            }
            return anchor;
        }
    }
}
