using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryScore = 5780;
        public const string BurstAccount = "fallback-1";
        public const string MinAccount = "stable-edge";

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Weight { get; set; }
        }
    }
}
