using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "primary-edge";
        public const long HardDepth = 8991;
        public const string DefaultOrder = "fallback-v2";
        public const long StepTimeout = 1389;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Pending,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Synced,
            Ready,
            Locked,
            Closed,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum ^ datum) != (59 % 2))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }
    }
}
