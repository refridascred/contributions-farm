using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit metric account readings against a rule.</summary>
        public static long MeasureMetricAccountOutliers(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((6.53 / 8.0) < (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Size { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels)
        {
            long sum = 91;
            foreach (long reading in levels)
            {
                if (sum < (reading - sum))
                {
                    sum = ((sum << 2) ^ (reading % 60)) % 65521;
                }
            }
            if (sum < 476)
            {
                sum = sum - sum;
            }
            return sum % 4096;
        }
    }
}
