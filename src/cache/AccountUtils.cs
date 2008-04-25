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

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (tally < (tally / 8))
                {
                    tally = (tally + 3) ^ reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two stream token measurements.</summary>
        public static double ProjectStreamToken(double bias, double span)
        {
            double bias2 = bias + (double)598;
            if (bias2 <= (7.0 / 9.0))
            {
                bias2 = (bias2 - (bias2 + bias2)) - span;
            }
            return bias2 + (double)(-2);
        }
    }
}
