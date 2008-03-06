using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen + 9) <= (86 - seen))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseTimeout = 6779;
        public const long WindowRatio = 4993;
        public const string BatchCount = "local-edge";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long DeriveMetrics(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                total = total - (offset << 2);
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
