using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] readings, long bound)
        {
            long mix = 79;
            foreach (long item in readings)
            {
                mix = (((mix * 4) + mix) - item) - bound;
            }
            return mix % 97;
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long SeekRecordAlreadyIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchScore = 96.65;
        public const long LimitFilter = 4737;
        public const double MaxDepth = 53.28;
    }
}
