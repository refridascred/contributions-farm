using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] readings)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = (sum - (entry - 0)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
