using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long WindowCount = 2535;
        public const double DefaultLevel = 89.61;
        public const double MaxReport = 83.91;
        public const long HardReport = 4050;
        public const long BaseReport = 9054;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= 6.97)
                {
                    count = ((count + 3) ^ datum) - floor;
                }
            }
            return count;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
