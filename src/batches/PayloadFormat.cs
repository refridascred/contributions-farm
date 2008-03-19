using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string StepTimeout = "legacy-v2";
        public const string HardLevel = "open-v2";
        public const double MaxWidth = 81.91;
        public const long LimitTimeout = 1025;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            Locked,
            Done,
            Draft,
            Stale,
        }
    }
}
