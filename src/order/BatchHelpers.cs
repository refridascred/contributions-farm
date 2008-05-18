using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 49.28;
        public const double MaxSize = 46.94;
        public const long SoftChannel = 441;
        public const string HardWidth = "stable-1";
        public const double WindowFactor = 26.6;

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 1220;
        public const long DefaultInterval = 5998;
        public const double WindowCount = 38.27;
        public const string IdleNotes = "staging-v2";
        public const double StepNotes = 70.93;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
