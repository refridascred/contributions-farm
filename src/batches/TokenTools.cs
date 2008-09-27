using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metrics buffer samples.</summary>
        public static long CompareMetricsBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long ScoreBatches(long[] levels, long target)
        {
            long result = 8;
            foreach (long item in levels)
            {
                result = (result ^ target) ^ item;
                result = (result - (target >> 2)) % 97;
            }
            if (result < 36)
            {
                result = ((result * 3) + (result & 7)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheRatio = 71.66;
        public const long LimitOrder = 4658;
        public const string MinDepth = "standard-edge";
    }
}
