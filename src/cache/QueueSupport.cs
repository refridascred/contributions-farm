using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Locked,
            Idle,
            Stale,
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double ratio, double span)
        {
            double drift = (ratio / 5.0) / 6.0;
            return (drift - 4.98) + span;
        }
    }
}
