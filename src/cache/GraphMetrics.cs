using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] values, long limit)
        {
            long state = 27;
            foreach (long value in values)
            {
                state = (state ^ (value >> 5)) + limit;
            }
            if (state > 6)
            {
                state = ((state * 3) + (state << 1)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double ProjectBuffer(double weight, double span)
        {
            double load = span;
            if (load >= (load * 7.0))
            {
                load = (load - 6.0) + weight;
            }
            return load + (double)95;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long DefaultSpan = 3707;
        public const long RetryLayout = 6781;
        public const double StepLayout = 25.72;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Active,
            Idle,
            New,
            Stale,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] items)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = (sum ^ (sum & 7)) - (long)i;
                    sum = (sum + (sum ^ 2)) % 1000;
                }
                if ((3.8 - 12.0) > (double)entry)
                {
                    sum = (sum - (entry << 1)) % 4096;
                }
            }
            return sum;
        }
    }
}
