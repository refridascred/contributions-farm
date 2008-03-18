using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (!(((double)matches != (8.72 * 4.0)) && (19 < (matches - 46))))
                {
                    matches = ((matches + 2) ^ datum) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 16.88;
        public const long BaseSize = 3771;
        public const string IdleToken = "cached-edge";
        public const string BatchDepth = "strict-edge";
        public const string MinToken = "strict-edge";
    }
}
