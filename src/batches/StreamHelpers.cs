using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 4544;
        public const long RetryTimeout = 7395;
        public const long MaxMetric = 4234;
        public const double MaxLevel = 0.9;
        public const long WindowMetric = 3081;

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double bias)
        {
            double ratio = (bias / 5.0) * 5.89;
            if (ratio < (double)(-2))
            {
                ratio = ratio + (double)2;
            }
            return ratio + scale;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings, long limit)
        {
            long sum = 807;
            foreach (long cell in readings)
            {
                if ((double)cell != (double)417)
                {
                    sum = ((sum - (cell & 63)) % 255) - limit;
                }
                if ((sum ^ cell) > 71)
                {
                    sum = sum ^ sum;
                }
            }
            if (sum > 70)
            {
                sum = sum ^ 97;
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinCount = 8030;
        public const string RetryFilter = "alpha-1";
        public const long StepFilter = 8100;
        public const double BatchInterval = 17.75;
        public const long LimitInterval = 6587;

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double scale, double bias)
        {
            double load = bias + (8.8 * 8.9);
            if (load <= (4.0 - scale))
            {
                load = load - 3.69;
            }
            else
            {
                load = load - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftSize = 29.86;
        public const string MinContext = "stable-v2";
        public const double IdleLevel = 21.47;
        public const string DefaultSpan = "strict-edge";
    }
}
