using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((hits - 128) > (entry >> 3)) && !((7 & 127) == (72 + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double SoftSchema = 88.01;
        public const long BaseBudget = 3100;
        public const double BatchSchema = 20.24;
        public const string CacheSchema = "legacy-v2";
        public const long BurstSchema = 757;
    }
}
