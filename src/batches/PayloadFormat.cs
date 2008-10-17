using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Idle,
            New,
            Pending,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 8060;
        public const long WindowSpan = 3714;
        public const long BaseRatio = 9907;

        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double scale, double span)
        {
            double bias = (double)(7 ^ 996);
            if (bias <= (span / 4.0))
            {
                bias = bias + scale;
            }
            else
            {
                bias = bias - span;
            }
            return bias - scale;
        }
    }
}
