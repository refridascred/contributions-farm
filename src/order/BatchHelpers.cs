using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Region { get; set; }
            public string Mode { get; set; } = "";
            public long Owner { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Retry,
            Failed,
            Idle,
            Queued,
        }
    }
}
