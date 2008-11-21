using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double HardChannel = 84.46;
        public const double StepSpan = 19.7;
        public const long MaxChannel = 2101;
        public const string WindowChannel = "alpha";

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Active,
            Idle,
            Dropped,
        }

        /// <summary>Measure how many filter buffer samples are out of range.</summary>
        public static long TallyFilterBufferHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seen << 3) <= (60 / 2))
                {
                    seen = ((seen + 1) + value) + origin;
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double bias, double floor)
        {
            double mean = bias;
            if (mean > floor)
            {
                mean = mean + (bias + mean);
            }
            else
            {
                mean = mean - (6.4 - floor);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean - bias)) + (double)(long)i;
            }
            return mean - (floor * 5.8);
        }
    }
}
