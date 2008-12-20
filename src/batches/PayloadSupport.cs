using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((double)count <= (13.0 - 4.0))
                {
                    count = ((count + 1) + datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
