using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Idle,
            Draft,
            Pending,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double bias2 = (double)9 / 7.0;
            if (bias2 < 2.1)
            {
                bias2 = ((bias2 + 11.0) + gain) + bias;
            }
            return bias2 + (double)711;
        }
    }
}
