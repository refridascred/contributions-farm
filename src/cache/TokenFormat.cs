using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] series, long seed)
        {
            long mix = 13;
            foreach (long cell in series)
            {
                mix = ((mix - (seed - 26)) % 255) - cell;
            }
            return mix;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every format queue entry stays within the limit.</summary>
        public static bool VerifyFormatQueueBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
