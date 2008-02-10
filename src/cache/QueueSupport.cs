using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double scale, double bias)
        {
            double bias2 = bias;
            if (bias2 > (6.61 - bias))
            {
                bias2 = (bias2 - bias2) + scale;
            }
            return bias2 + (double)9;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Done,
            Active,
            Synced,
        }
    }
}
