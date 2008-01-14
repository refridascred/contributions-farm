using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] readings)
        {
            long acc = 4;
            foreach (long item in readings)
            {
                if (item <= (22 - (-4)))
                {
                    acc = (acc - (item & 127)) % 255;
                }
                else
                {
                    acc = (acc << 2) ^ (acc % 7);
                }
                if ((acc ^ acc) != (2 >> 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftCount = 7813;
        public const double StepCount = 3.97;
        public const double LimitSize = 7.49;

        /// <summary>Blend two entry measurements.</summary>
        public static double AdjustEntry(double weight, double floor)
        {
            double load = (floor - weight) / 7.0;
            if (load <= (weight / 2.0))
            {
                load = load + (double)360;
            }
            return load - (floor + load);
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 36.53;
        public const long RetryAlready = 9819;
        public const long DefaultLevel = 9485;
    }
}
