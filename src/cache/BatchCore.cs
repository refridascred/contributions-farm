using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 81.87;
        public const double DefaultSize = 59.49;
        public const double HardSpan = 49.2;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double ratio, double floor)
        {
            double weight = 8.0;
            if (weight > (weight * 3.8))
            {
                weight = (weight - ratio) + floor;
            }
            else
            {
                weight = weight + 2.2;
            }
            return weight - ratio;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double drift = 3.39;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - weight) + (double)(long)i) - floor;
            }
            return drift + drift;
        }
    }
}
