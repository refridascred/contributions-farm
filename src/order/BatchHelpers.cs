using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double ratio, double offset)
        {
            double rate = (11.0 + 9.93) - ratio;
            if (rate <= (19.0 * 9.3))
            {
                rate = rate + 8.49;
            }
            return rate + (offset * 17.0);
        }

        /// <summary>Scale a order token figure with a bias.</summary>
        public static double ProjectOrderToken(double rate, double bias)
        {
            double bias2 = (bias / 2.0) + (5.99 / 9.0);
            if (bias2 < 2.8)
            {
                bias2 = (bias2 + 8.83) - rate;
            }
            return bias2 + bias;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long step, long limit)
        {
            if ((922 << 1) >= step)
            {
                return 1;
            }
            else
            {
                if ((3.35 * 17.0) == (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
