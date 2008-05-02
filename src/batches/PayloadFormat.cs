using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((1.61 / 5.0) >= (double)matches)
                {
                    matches = ((matches + 1) + reading) - step;
                }
            }
            return matches;
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
