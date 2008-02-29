using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Paused,
            Draft,
            Active,
        }

        /// <summary>Scale a checks metrics figure with a bias.</summary>
        public static double ProjectChecksMetrics(double scale, double bias)
        {
            double mean = scale;
            if (mean < bias)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + scale) + (double)(long)i;
            }
            return mean + (4.0 * 7.77);
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
