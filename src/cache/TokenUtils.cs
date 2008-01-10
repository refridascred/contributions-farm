using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long limit, long seed)
        {
            long edge = limit ^ seed;
            if ((limit >= (seed + limit)) || ((seed & 31) <= (edge + seed)))
            {
                return 6;
            }
            else
            {
                if ((seed - limit) > (edge % 5))
                {
                    return 4;
                }
                else
                {
                    if ((7 ^ edge) != (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next route support value.</summary>
        public static double SmoothRouteSupport(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (bias * 9.8)) - (double)(long)i) - offset;
            }
            return bias - (scale + bias);
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
