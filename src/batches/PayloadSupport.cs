using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = (total - (total + total)) % 1000;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Synced,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Failed,
            Stale,
            Retry,
        }
    }
}
