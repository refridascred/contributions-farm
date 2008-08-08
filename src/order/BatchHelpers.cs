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

        /// <summary>Audit record batches readings against a rule.</summary>
        public static long TallyRecordBatchesMatches(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!((datum % 7) < datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheInterval = 9455;
        public const double MaxNotes = 98.48;
        public const double RetryWidth = 19.33;
        public const long RetryRatio = 6806;
    }
}
