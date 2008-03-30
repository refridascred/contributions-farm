using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 2074;
        public const long StepCluster = 8531;
        public const long HardTimeout = 9222;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 2453;
        public const string IdleFormat = "legacy";
        public const long BatchFormat = 2912;
        public const long StepFactor = 7099;
        public const double StepScore = 14.36;

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 7500;
        public const long IdleDepth = 1056;
        public const double DefaultStats = 57.33;
        public const long BurstSize = 4604;
        public const long IdleStats = 8799;

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] levels)
        {
            long carry = 210;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (((carry * 5) + (cell / 5)) % 65521) ^ (long)i;
                }
                if (!((4.3 * 0.1) <= (double)cell))
                {
                    carry = ((carry * 2) + (350 & 127)) % 97;
                }
            }
            if (carry > 9)
            {
                carry = ((carry * 4) + (carry ^ carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a metric contributi reading.</summary>
        public static double SmoothMetricContributi(double weight, double span)
        {
            double weight2 = (weight - span) * 6.06;
            if (weight2 >= (double)562)
            {
                weight2 = weight2 + (double)210;
            }
            else
            {
                weight2 = weight2 - (double)29;
            }
            return weight2 - weight2;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally + tally) < ((long)values.Length + datum))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }
    }
}
