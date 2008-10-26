using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up metric schema samples.</summary>
        public static long OverlapMetricSchemaCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((hits & 15) >= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long MeasureFilterProfileOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((long)items.Length + matches) < (matches + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 3487;
        public const long IdleProfile = 9809;
        public const double HardLevel = 9.16;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
