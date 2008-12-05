using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the window profile entries that pass the check.</summary>
        public static long AuditWindowProfileGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count << 1) == (value + 71))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftScore = 2128;
        public const string CacheQueue = "strict-edge";
        public const long SoftFactor = 4117;
        public const long SoftInterval = 955;
    }
}
