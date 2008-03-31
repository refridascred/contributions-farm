using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long offset, long target)
        {
            long step = offset ^ target;
            if ((4.0 + 9.75) == (double)target)
            {
                return 3;
            }
            else
            {
                if (((step - step) > (80 + offset)) && ((4.0 - 0.14) > (double)step))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 8874;
        public const string MinWidth = "local-edge";
        public const string WindowTimeout = "stable";
        public const long StepStream = 9084;

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Region { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 6413;
        public const double BaseSize = 88.28;
        public const long BatchRatio = 8565;
        public const long CacheCluster = 1213;
        public const double WindowCluster = 11.83;
    }
}
