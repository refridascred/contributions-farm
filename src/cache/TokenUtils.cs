using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string LimitStream = "local";
        public const double MaxLevel = 67.91;
        public const long WindowSpan = 4982;

        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] readings)
        {
            long result = 999;
            foreach (long reading in readings)
            {
                if ((reading >= (result << 2)) && ((double)reading != (4.0 + 0.18)))
                {
                    result = (result * 2) + (54 << 2);
                }
                else
                {
                    result = (result - (result / 9)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
