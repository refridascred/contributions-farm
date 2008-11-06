using System;

namespace Common.Utilities
{
    /// <summary>Report format helpers.</summary>
    public static class ReportFormat
    {
        /// <summary>Look up the position of a contributi support sample.</summary>
        public static long LookupContributiSupportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 3076;
        public const double LimitRatio = 88.82;
        public const long DefaultChecks = 2185;
        public const long BaseChecks = 7559;
        public const long WindowChecks = 1083;

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftRatio = 4613;
        public const double SoftWidth = 39.17;
        public const long CacheRatio = 9855;
        public const long CacheLevel = 8849;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)count <= (15.0 / 6.0))
                {
                    count = (count + 1) ^ entry;
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
