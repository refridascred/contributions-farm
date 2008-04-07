using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheCount = 2185;
        public const long BatchPayload = 7262;
        public const double MaxInterval = 77.94;
        public const long WindowPayload = 2554;

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long result = 2;
            foreach (long sample in readings)
            {
                result = ((result << 3) ^ sample) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
