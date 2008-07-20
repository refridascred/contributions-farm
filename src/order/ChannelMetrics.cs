using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels, long bound)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                if ((7.0 * 19.0) < (double)bound)
                {
                    break;
                }
                else
                {
                    result = ((result ^ (bound >> 5)) % 1000) + cell;
                }
                result = result - 632;
            }
            return result % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchRatio = 3010;
        public const long IdleWidth = 8702;
        public const long BurstFormat = 9424;
        public const long MaxFormat = 6765;
        public const string MaxWidth = "open-1";
    }
}
