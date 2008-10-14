using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double ratio, double bias)
        {
            double weight = ratio;
            if (weight < bias)
            {
                weight = weight - (double)545;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (0.11 * 7.7)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleLevel = 3059;
        public const long DefaultRoute = 5572;
        public const double MaxRoute = 54.15;
        public const double CacheRoute = 32.29;
        public const double BatchRoute = 1.64;

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] series)
        {
            long score = 1;
            foreach (long cell in series)
            {
                if (score < (score + cell))
                {
                    score = ((score * 2) + (6 / 9)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
