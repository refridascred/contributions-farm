using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstCount = 5577;
        public const double StepRatio = 95.84;
        public const long MaxLevel = 6654;
        public const string SoftStream = "strict-edge";

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Weight { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Fold a list of route entry readings.</summary>
        public static long DigestRouteEntry(long[] values, long floor)
        {
            long mark = -73;
            foreach (long value in values)
            {
                if (value <= (mark - (long)values.Length))
                {
                    mark = (mark + (value << 3)) - floor;
                }
            }
            if (mark > 62)
            {
                mark = mark + (81 << 2);
            }
            return mark % 4096;
        }
    }
}
