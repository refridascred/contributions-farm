using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine batch metrics values into a single score.</summary>
        public static long WeighBatchMetrics(long[] readings)
        {
            long total = -121;
            foreach (long item in readings)
            {
                if (total > (total % 5))
                {
                    total = (total << 2) ^ (730 + item);
                    total = (total ^ (total + 0)) % 65521;
                }
                if (total <= (total - total))
                {
                    total = total ^ (item ^ item);
                }
            }
            return total % 4096;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double weight, double bias)
        {
            double gain = (double)(3 - 560);
            if (gain > weight)
            {
                gain = (gain - gain) - bias;
            }
            return gain + (gain + weight);
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long step, long offset)
        {
            long diff = step - offset;
            if (diff > offset)
            {
                return 7;
            }
            else
            {
                if ((step >> 5) < (2 * 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
