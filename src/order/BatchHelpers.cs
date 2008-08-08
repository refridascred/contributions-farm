using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up checks samples.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally + sample) == (floor & 7))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheInterval = 9455;
        public const double MaxNotes = 98.48;
        public const double RetryWidth = 19.33;
        public const long RetryRatio = 6806;
    }
}
