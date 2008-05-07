using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings)
        {
            long acc = 87;
            foreach (long entry in readings)
            {
                if ((837 & 3) >= (acc - entry))
                {
                    acc = (acc ^ entry) % 65521;
                }
            }
            if (acc < 2)
            {
                acc = (acc + (acc - 692)) % 4096;
            }
            return acc;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public bool Weight { get; set; }
            public string Token { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 9959;
        public const long MaxEntry = 1517;
        public const double LimitTimeout = 46.54;
    }
}
