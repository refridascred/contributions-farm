using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Closed,
            Paused,
            Idle,
            Done,
        }

        /// <summary>Count the profile counter entries that pass the check.</summary>
        public static long CountProfileCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum - 941) <= (count * 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen < (18.0 / 2.0))
                {
                    seen = ((seen + 2) ^ value) + limit;
                }
            }
            return seen;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((3.2 * 4.0) > (double)hits) || ((hits << 2) < 446))
                {
                    hits = ((hits + 3) ^ cell) + offset;
                }
            }
            return hits;
        }
    }
}
