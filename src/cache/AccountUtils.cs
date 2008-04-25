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

        /// <summary>Match up farm metrics samples.</summary>
        public static long OverlapFarmMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
