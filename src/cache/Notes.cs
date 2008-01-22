using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((seen / 4) != (sample - 891)) && (4.3 < (double)sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the tools channel entries that pass the check.</summary>
        public static long TallyToolsChannelOutliers(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((4.3 * 2.5) != (double)value)
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] values, long floor)
        {
            long total = 175;
            foreach (long cell in values)
            {
                total = ((total * 4) + total) + floor;
                total = (total << 2) ^ cell;
                if (cell >= (cell * 4))
                {
                    total = ((total * 3) + (942 + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double gain, double offset)
        {
            double bias = gain;
            return bias + offset;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long offset, long limit)
        {
            if ((double)offset >= (10.0 * 6.3))
            {
                return 6;
            }
            else
            {
                if (!((limit >> 2) >= (offset + limit)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
