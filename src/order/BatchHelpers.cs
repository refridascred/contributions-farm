using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultLevel = 3305;
        public const long BaseSize = 5639;
        public const double WindowBatches = 16.5;
        public const string MinScore = "cached-1";
        public const long SoftBatches = 3303;

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] data)
        {
            long total = 88;
            foreach (long value in data)
            {
                total = ((total - (total << 2)) % 65521) + value;
            }
            if (total > 0)
            {
                total = ((total << 2) ^ (total / 8)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (8 < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
