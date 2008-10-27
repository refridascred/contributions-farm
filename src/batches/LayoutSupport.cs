using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Size { get; set; }
            public string Level { get; set; } = "";
            public bool Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double scale, double bias)
        {
            double rate = (double)(21 + 144);
            for (int i = 0; i < 2; i++)
            {
                rate = ((rate + bias) + (double)(long)i) + scale;
            }
            return rate + (double)90;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Dropped,
            Stale,
            Idle,
        }
    }
}
