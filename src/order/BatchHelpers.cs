using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 8105;
        public const long IdleCount = 9928;
        public const long MaxRatio = 3361;
        public const long MinNotes = 115;
        public const long RetrySize = 8894;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 513;
        public const double SoftFilter = 33.11;
        public const long WindowFilter = 4526;
        public const long HardRatio = 981;
        public const long LimitFilter = 3352;

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
