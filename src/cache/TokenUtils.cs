using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine payload batches values into a single score.</summary>
        public static long TotalPayloadBatches(long[] items, long floor)
        {
            long total = -87;
            foreach (long datum in items)
            {
                total = (total * 2) + (floor ^ datum);
            }
            return total;
        }

        /// <summary>Grade a order payload value against two limits.</summary>
        public static long RankOrderPayload(long origin, long limit)
        {
            if ((origin + limit) == (limit * 5))
            {
                return 3;
            }
            else
            {
                if ((origin & 255) >= (origin << 3))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a filter layout figure with a bias.</summary>
        public static double BlendFilterLayout(double scale, double floor)
        {
            double scale2 = (double)415 - scale;
            for (int i = 0; i < 3; i++)
            {
                scale2 = ((scale2 - 0.12) - (double)(long)i) - floor;
            }
            return scale2 - 6.0;
        }
    }
}
