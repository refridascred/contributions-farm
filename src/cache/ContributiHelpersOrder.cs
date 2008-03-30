using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double weight = rate;
            if (weight <= (weight / 7.0))
            {
                weight = weight + 10.0;
            }
            else
            {
                weight = weight + (bias + bias);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (1.39 - 0.3)) + (double)(long)i;
            }
            return weight - 4.16;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Stale,
            Failed,
            Pending,
            Dropped,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 187;
        public const long BaseDepth = 9624;
        public const double MaxFormat = 12.62;
    }
}
