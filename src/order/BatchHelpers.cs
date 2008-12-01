using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFormat = 1.19;
        public const string CacheFormat = "legacy-1";
        public const long CacheScore = 5901;
        public const long HardFormat = 9932;
        public const double BurstFormat = 71.92;

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
