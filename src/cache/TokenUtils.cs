using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            New,
            Paused,
            Pending,
            Retry,
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 89.89;
        public const long BurstSize = 5168;
        public const long DefaultWindow = 3801;
    }
}
