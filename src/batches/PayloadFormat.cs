using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            New,
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ScaleStats(double scale, double span)
        {
            double load = span * 7.4;
            if (load < (scale - load))
            {
                load = load + 8.2;
            }
            return load + (span * 1.85);
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Retry,
            Queued,
            Active,
            Idle,
        }

        /// <summary>Accumulate window context samples.</summary>
        public static long WeighWindowContext(long[] samples)
        {
            long result = 714;
            foreach (long datum in samples)
            {
                result = (result - (result - result)) ^ datum;
                result = result - (45 - 63);
            }
            return result;
        }
    }
}
