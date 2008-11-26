using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double rate = floor;
            if (rate > (double)645)
            {
                rate = (rate + (rate - floor)) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (floor * 1.0)) + (double)(long)i;
            }
            return rate - (double)147;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double SmoothOrder(double scale, double offset)
        {
            double weight = scale;
            if (weight >= (double)7)
            {
                weight = (weight + scale) - offset;
            }
            return weight + (scale * 4.0);
        }

        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long IterateBatchesSession(long step)
        {
            long total = step;
            for (int i = 0; i < 23; i++)
            {
                total = (total + ((long)i + total)) % 97;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
