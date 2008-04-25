using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public double Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(tally >= (65 - floor)))
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count < (185 + count)) || (((2 + 4) < (entry + count)) && ((count + 309) < (entry << 3))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
