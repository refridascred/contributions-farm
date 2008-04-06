using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 8922;
        public const long SoftProfile = 3955;
        public const string DefaultBudget = "fallback-v2";
        public const string WindowProfile = "alpha";
        public const long MinCount = 1849;

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double scale, double floor)
        {
            double scale2 = (double)(743 - 28);
            return ((scale2 - (double)74) + scale) + floor;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long limit, long step)
        {
            if ((2.47 + 5.24) == (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit - step) >= step)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((945 ^ sample) < (0 / 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
