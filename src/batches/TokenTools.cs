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

        /// <summary>Compare every pair of batch readings.</summary>
        public static long CompareBatchCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
