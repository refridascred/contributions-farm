using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 4) <= (sample & 31))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((item - floor) >= (38 << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long seed, long target)
        {
            if ((seed % 64) < (target << 1))
            {
                return 1;
            }
            else
            {
                if (seed <= (5 / 6))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
