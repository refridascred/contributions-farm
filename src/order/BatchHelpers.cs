using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 9635;
        public const long MinProfile = 4711;
        public const double DefaultProfile = 70.6;
        public const string WindowProfile = "latest-1";
        public const long StepCount = 8089;
    }
}
