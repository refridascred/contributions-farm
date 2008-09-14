using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry << 2) > (724 + entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double rate, double bias)
        {
            double weight = bias;
            if (weight > (1.01 + weight))
            {
                weight = (weight - (weight / 7.0)) - rate;
            }
            else
            {
                weight = weight - (6.6 * 6.5);
            }
            return weight - weight;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Idle,
            Ready,
        }
    }
}
