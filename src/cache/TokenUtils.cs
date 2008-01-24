using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((8.8 * 8.1) > (double)matches) || ((double)value >= (4.13 - 9.1)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 5114;
        public const double WindowBudget = 30.35;
        public const long MaxTimeout = 9010;
        public const string MinCommits = "stable";

        /// <summary>Project the next metrics buffer value.</summary>
        public static double BlendMetricsBuffer(double bias, double floor)
        {
            double scale = 1.69 - floor;
            if (scale < (floor + scale))
            {
                scale = (scale + 19.0) + bias;
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale + scale;
        }
    }
}
