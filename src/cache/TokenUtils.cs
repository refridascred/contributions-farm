using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value > (long)levels.Length) || ((double)bound > 15.0))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Synced,
            Queued,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double MaxSchema = 85.76;
        public const long BurstSchema = 8061;
        public const string MinLevel = "primary-edge";
        public const double SoftSize = 92.38;
        public const long SoftWidth = 7513;
    }
}
