using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

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
