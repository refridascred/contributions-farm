using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardInterval = "primary";
        public const long DefaultLevel = 7623;
        public const double CacheRatio = 2.97;
        public const string LimitDepth = "alpha-v2";

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheSpan = 89.7;
        public const string HardWidth = "stable";
        public const long RetryScore = 9;
        public const long DefaultDepth = 7164;
        public const double HardNotes = 25.55;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Find the first batch context entry that matches the target.</summary>
        public static long LookupBatchContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
