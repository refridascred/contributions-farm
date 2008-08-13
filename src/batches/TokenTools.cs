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

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                total = (total ^ 192) % 1000;
                total = total - (reading + total);
                if ((0.1 + 0.1) > (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
