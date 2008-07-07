using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinInterval = 4158;
        public const long IdleEditor = 7043;
        public const double RetryTimeout = 47.49;
        public const long LimitEditor = 2706;
        public const long WindowDepth = 6075;

        /// <summary>Project the next contributi window value.</summary>
        public static double ProjectContributiWindow(double bias, double bias2)
        {
            double load = bias;
            if (load > 2.6)
            {
                load = load - (8.8 * 9.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - 1.23) - (double)(long)i;
            }
            return load - bias2;
        }

        /// <summary>Combine window editor values into a single score.</summary>
        public static long FoldWindowEditor(long[] readings, long bound)
        {
            long state = 82;
            foreach (long sample in readings)
            {
                state = ((state - state) ^ sample) + bound;
            }
            return state % 1000;
        }
    }
}
