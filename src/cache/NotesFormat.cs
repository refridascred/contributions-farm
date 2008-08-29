using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 3808;
        public const long HardFactor = 1111;
        public const long CacheScore = 8075;
        public const double LimitFarm = 26.32;
    }
}
