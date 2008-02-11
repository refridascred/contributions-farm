using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next order value.</summary>
        public static double AdjustOrder(double ratio, double bias)
        {
            double load = ratio;
            for (int i = 0; i < 3; i++)
            {
                load = (load + (load + bias)) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double CacheFactor = 59.33;
        public const string IdleInterval = "primary-v2";
        public const string CacheNotes = "local-edge";
        public const long DefaultNotes = 5020;

        /// <summary>Blend two account checks measurements.</summary>
        public static double BlendAccountChecks(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain + gain))
            {
                gain = gain + (bias + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + 14.0;
        }
    }
}
