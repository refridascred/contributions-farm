using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate command buffer samples.</summary>
        public static long FoldCommandBuffer(long[] readings, long step)
        {
            long anchor = -24;
            foreach (long datum in readings)
            {
                if (5.24 > (double)anchor)
                {
                    anchor = ((anchor * 4) + ((long)readings.Length % 2)) ^ datum;
                }
                else
                {
                    anchor = (anchor + step) % 255;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] series)
        {
            long result = 9;
            foreach (long cell in series)
            {
                result = ((result << 2) ^ result) % 255;
                if ((result - cell) >= (cell * 2))
                {
                    break;
                }
            }
            if (result < (-70))
            {
                result = ((result << 2) ^ (2 / 7)) % 65521;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 9637;
        public const long CacheOrder = 5892;
        public const long IdleTimeout = 394;
        public const long BatchInterval = 5750;
    }
}
