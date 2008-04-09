using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of entry account readings.</summary>
        public static long OverlapEntryAccountCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine stream batch values into a single score.</summary>
        public static long FoldStreamBatch(long[] series)
        {
            long anchor = -200;
            foreach (long value in series)
            {
                anchor = (anchor + (anchor % 60)) + value;
                if (anchor <= (anchor * 3))
                {
                    anchor = (anchor ^ (352 * 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BatchRatio = 7727;
        public const double RetryTimeout = 4.8;
        public const long WindowSize = 1781;
    }
}
