using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!((double)count <= (double)reading))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitMetric = "strict";
        public const string BaseCount = "open-edge";
        public const long HardMetric = 3425;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ProjectCounter(double ratio, double bias)
        {
            double scale = ratio;
            return scale + (bias - 6.5);
        }
    }
}
