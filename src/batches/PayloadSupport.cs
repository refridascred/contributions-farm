using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

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
