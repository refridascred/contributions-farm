using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 5180;
        public const long WindowSize = 7431;
        public const long SoftInterval = 1107;
        public const long DefaultCounter = 8931;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Weight { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
