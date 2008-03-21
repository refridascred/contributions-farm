using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinDepth = 8990;
        public const long MaxBudget = 1665;
        public const long RetryTimeout = 4979;
        public const long SoftAccount = 350;
        public const long IdleCount = 5283;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Ready,
            New,
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double SmoothQueue(double scale, double floor)
        {
            double load = 20.0 * 5.6;
            return ((load + load) + scale) + floor;
        }

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderOutliers(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (value >= (value + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (tally > (tally << 1))
                {
                    tally = ((tally + 2) + reading) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
