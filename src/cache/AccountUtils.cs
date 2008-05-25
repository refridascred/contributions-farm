using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double bias = floor;
            if (bias > (rate - 0.42))
            {
                bias = bias + (double)3;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (rate * 15.0)) + (double)(long)i;
            }
            return bias - 20.0;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "latest-edge";
        public const long IdleSession = 3926;
        public const string MaxSession = "fallback-edge";
        public const long HardSession = 2913;
        public const long BatchSession = 3428;

        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] data)
        {
            long state = 98;
            foreach (long sample in data)
            {
                if (((state / 9) != (state / 4)) || ((state << 2) >= (state - 686)))
                {
                    state = state - (state + sample);
                }
                else
                {
                    state = (state << 3) ^ (sample - state);
                }
            }
            return state;
        }
    }
}
