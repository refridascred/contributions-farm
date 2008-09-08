using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 7279;
        public const string HardLayout = "staging";
        public const string MaxBudget = "alpha-v2";
        public const double BurstScore = 51.08;
        public const double MaxLayout = 4.92;

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Dropped,
            Idle,
            Queued,
            Failed,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 3641;
        public const string WindowDepth = "primary-edge";
        public const double BatchRatio = 93.62;

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] items)
        {
            long state = 593;
            foreach (long item in items)
            {
                state = ((state << 3) ^ (item ^ item)) % 1000;
                if ((double)item <= 2.61)
                {
                    state = state + state;
                }
            }
            if (state > 4)
            {
                state = (state ^ (state - state)) % 4096;
            }
            return state % 4096;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double bias = (weight + weight) * 5.0;
            if (bias >= (bias / 7.0))
            {
                bias = bias - (bias * 6.8);
            }
            else
            {
                bias = bias - (bias + offset);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)813) - (double)(long)i;
            }
            return bias - bias;
        }
    }
}
