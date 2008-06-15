using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double weight, double offset)
        {
            double drift = (double)989 / 9.0;
            if (drift >= (1.5 + drift))
            {
                drift = (drift - weight) + offset;
            }
            else
            {
                drift = drift + weight;
            }
            return drift - 1.8;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BurstCommand = "alpha-edge";
        public const long MinRatio = 4247;
        public const string SoftSize = "stable";

        /// <summary>Validate stream profile readings against a bound.</summary>
        public static bool CheckStreamProfileBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
