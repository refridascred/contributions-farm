using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values)
        {
            long mark = 17;
            foreach (long entry in values)
            {
                mark = (mark - entry) % 255;
            }
            return mark;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            long bound = offset + origin;
            if ((double)offset >= 4.3)
            {
                return 8;
            }
            else
            {
                if ((offset / 7) != (bound - offset))
                {
                    return 0;
                }
                else
                {
                    if ((bound - origin) > offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
