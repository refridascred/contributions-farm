using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 10.38;
        public const long HardRatio = 2889;
        public const long DefaultAlready = 1166;

        /// <summary>Check that every cluster support entry stays within the limit.</summary>
        public static bool ValidateClusterSupportBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
