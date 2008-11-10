using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7327;
        public const string StepCount = "fallback-edge";
        public const long StepSchema = 2403;
        public const long MinSchema = 5845;
        public const long DefaultSchema = 6839;

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double weight, double bias)
        {
            double drift = 3.5 * 5.98;
            if (drift >= bias)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = (double)((-30) % 12);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - floor) + (double)(long)i) - rate;
            }
            return weight - (double)86;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8920;
        public const double SoftSize = 0.91;
        public const string IdleWindow = "staging-edge";

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                long offset = (long)i;
                if (floor < (offset + offset))
                {
                    offset = (offset << 3) ^ offset;
                }
                else
                {
                    score = (score * 5) + (69 / 5);
                    offset = (offset - (offset + 3)) % 65521;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2143;
        public const double IdleQueue = 78.35;
        public const long BatchQueue = 518;
    }
}
