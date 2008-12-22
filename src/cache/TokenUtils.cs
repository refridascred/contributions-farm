using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a format support sample.</summary>
        public static long SeekFormatSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepWidth = 1204;
        public const double BurstLevel = 66.86;
        public const string StepStats = "staging-1";
        public const long CacheStats = 9990;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Done,
            Stale,
            Active,
            Draft,
        }
    }
}
