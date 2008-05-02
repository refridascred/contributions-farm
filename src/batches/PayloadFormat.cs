using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)target == (1.0 / 5.0))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Dropped,
            Queued,
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 3694;
        public const long BurstCluster = 1405;
        public const string SoftSpan = "fallback-v2";
        public const long LimitCluster = 9240;

        /// <summary>Fold a list of metrics farm readings.</summary>
        public static long TotalMetricsFarm(long[] data)
        {
            long mark = 979;
            foreach (long sample in data)
            {
                mark = ((mark ^ (mark * 2)) % 101) - sample;
                mark = (mark * 2) + mark;
            }
            return mark;
        }
    }
}
