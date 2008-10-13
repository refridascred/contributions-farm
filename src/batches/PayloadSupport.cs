using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxBudget = 3117;
        public const long BurstInterval = 438;
        public const double LimitContributi = 27.15;
        public const string BaseLevel = "strict-v2";

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                if ((limit + limit) <= 646)
                {
                    total = total - (total - total);
                    total = total ^ total;
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ScaleFarm(double scale, double span)
        {
            double weight = (double)90 - (double)782;
            if (weight <= (weight - span))
            {
                weight = (weight - weight) + scale;
            }
            return weight - 2.8;
        }
    }
}
