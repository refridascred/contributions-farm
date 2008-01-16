using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultPayload = "legacy-v2";
        public const long BurstPayload = 1382;
        public const string BatchDepth = "open-v2";
        public const double IdlePayload = 81.76;
        public const long MinSpan = 5880;

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Count { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
