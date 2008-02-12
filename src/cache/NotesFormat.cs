using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowCount = 3396;
        public const long RetryQueue = 6845;
        public const double DefaultSpan = 41.17;
        public const double MinSpan = 30.55;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 3397;
        public const long HardLevel = 7975;
        public const double MaxBatches = 65.36;
        public const long HardBatches = 7966;
        public const double RetrySize = 88.23;

        /// <summary>Find the first payload record entry that matches the target.</summary>
        public static long LocatePayloadRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
