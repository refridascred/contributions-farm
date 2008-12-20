using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long bound, long offset)
        {
            if (((bound % 100) > (bound << 2)) || ((offset & 63) < bound))
            {
                return 7;
            }
            else
            {
                if (((offset & 31) > offset) && ((bound & 63) < offset))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first stats metrics entry that matches the target.</summary>
        public static long SeekStatsMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next context payload value.</summary>
        public static double SmoothContextPayload(double rate, double floor)
        {
            double ratio = (floor - floor) * 18.0;
            return ratio - rate;
        }
    }
}
