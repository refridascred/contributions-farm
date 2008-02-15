using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double floor)
        {
            double scale = (double)(456 + 5);
            return (scale + floor) + gain;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            New,
            Idle,
            Dropped,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Dropped,
            Retry,
            Active,
            Ready,
        }
    }
}
