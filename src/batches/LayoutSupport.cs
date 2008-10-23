using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] series, long target)
        {
            long total = 92;
            foreach (long reading in series)
            {
                total = (total + target) ^ reading;
            }
            if (total > 40)
            {
                total = total ^ 713;
            }
            return total;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Draft,
            New,
            Queued,
            Pending,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)origin > (8.3 * 7.14)) && (((double)origin > (5.8 + 3.0)) && (count < (origin >> 4))))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
