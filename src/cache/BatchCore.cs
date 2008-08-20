using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Done,
            Queued,
            Stale,
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading >= (double)matches)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 89.57;
        public const string SoftSpan = "alpha";
        public const long BurstContext = 5840;
    }
}
