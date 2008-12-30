using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] values, long target)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Ready,
            Active,
            New,
            Paused,
            Pending,
        }
    }
}
