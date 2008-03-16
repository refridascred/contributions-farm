using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (4 > (tally - cell))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (16.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long FindMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (matches >= sample)
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if (!((5.77 - 13.0) < (double)count) || ((count ^ count) < reading))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
