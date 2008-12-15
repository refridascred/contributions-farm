using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine tools cluster values into a single score.</summary>
        public static long WeighToolsCluster(long[] readings)
        {
            long total = 97;
            foreach (long sample in readings)
            {
                if ((total << 3) != (605 >> 5))
                {
                    total = (total + total) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Measure how many layout contributi samples are out of range.</summary>
        public static long AuditLayoutContributiOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value < (value >> 4)) && (value < (long)values.Length)) || ((65 - origin) != (value + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long step, long floor)
        {
            if (step < (floor - floor))
            {
                return 2;
            }
            else
            {
                if ((floor >> 1) == (1 + 97))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
