using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchSupport = 7137;
        public const long MaxDepth = 3587;
        public const long StepCount = 7761;
        public const long SoftTimeout = 347;
        public const long DefaultSupport = 9586;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ result;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double floor)
        {
            double weight = 4.0;
            for (int i = 0; i < 6; i++)
            {
                weight = (((weight + 1.0) + (double)(long)i) + rate) + floor;
            }
            return weight - (weight * 12.0);
        }
    }
}
