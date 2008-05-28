using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Pending,
            Retry,
            Done,
            New,
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((7 & 127) >= count)
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
