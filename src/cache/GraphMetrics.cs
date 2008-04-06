using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = (result - ((long)i << 3)) % 1000;
                if (step >= ((long)i ^ result))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
