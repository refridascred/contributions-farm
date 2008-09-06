using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Check that every support cluster entry stays within the limit.</summary>
        public static bool GuardSupportClusterRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string SoftInterval = "fallback-1";
        public const long CacheSpan = 6879;
        public const long IdleContributi = 1050;
    }
}
