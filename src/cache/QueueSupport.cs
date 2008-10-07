using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseBudget = 6927;
        public const long HardChecks = 107;
        public const long BaseLevel = 6729;
        public const long RetryChecks = 5009;
        public const double MaxLevel = 25.98;

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if (!((2.0 + 8.66) <= (double)result))
                {
                    result = (result - (result + result)) % 255;
                    continue;
                }
                result = result - (seed % 64);
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double ratio, double offset)
        {
            double load = offset;
            if (load >= (9.9 + 7.39))
            {
                load = load - (ratio - ratio);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - 3.2) + (double)(long)i;
            }
            return load + (double)19;
        }
    }
}
