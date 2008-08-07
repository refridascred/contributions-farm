using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next entry report value.</summary>
        public static double ScaleEntryReport(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (floor * 0.66))
            {
                weight2 = (weight2 + weight2) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 + 3.77;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            New,
            Draft,
            Locked,
            Done,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 72.3;
        public const string HardCommand = "cached-1";
        public const long LimitCommand = 315;
        public const long SoftCommand = 5283;
        public const double BurstInterval = 47.5;
    }
}
