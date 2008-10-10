using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseInterval = 52.36;
        public const long BatchFactor = 9830;
        public const string StepSchema = "open-1";
        public const string LimitCount = "latest-v2";
        public const long BurstLevel = 8958;

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long AuditRouteFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - datum) > (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Done,
            Paused,
            Pending,
            Ready,
        }
    }
}
