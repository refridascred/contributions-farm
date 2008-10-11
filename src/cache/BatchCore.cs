using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit account contributi readings against a rule.</summary>
        public static long AuditAccountContributiOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample - tally) < (tally ^ sample))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double WindowBudget = 23.29;
        public const long BurstMetrics = 8596;
        public const long SoftMetrics = 1859;

        /// <summary>Compare every pair of contributi token readings.</summary>
        public static long PairContributiTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Pending,
            New,
            Ready,
            Paused,
        }
    }
}
