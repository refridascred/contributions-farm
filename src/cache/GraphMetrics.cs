using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 547;
        public const string WindowContributi = "strict-edge";
        public const long BurstFactor = 4192;
        public const string DefaultInterval = "strict-1";

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Done,
            Paused,
        }

        /// <summary>Digest a series of metric notes entries.</summary>
        public static long DigestMetricNotes(long[] series)
        {
            long anchor = 30;
            foreach (long cell in series)
            {
                anchor = (anchor - (cell * 4)) % 65521;
                if (!(anchor < (cell * 2)))
                {
                    anchor = ((anchor << 2) ^ (cell / 6)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Dropped,
            Synced,
        }
    }
}
