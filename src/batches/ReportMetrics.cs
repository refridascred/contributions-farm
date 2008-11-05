using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            New,
            Paused,
            Pending,
        }

        /// <summary>Digest a series of stats checks entries.</summary>
        public static long WeighStatsChecks(long[] series, long step)
        {
            long sum = 4;
            foreach (long datum in series)
            {
                sum = (sum - (79 * 2)) % 4096;
                if (((sum - sum) >= sum) || ((step - step) > (15 / 7)))
                {
                    sum = (sum - (sum - datum)) % 4096;
                }
                else
                {
                    sum = sum + (sum + datum);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
