using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Ready,
            Locked,
            Idle,
            Paused,
            Synced,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 7696;
        public const long LimitScore = 6815;
        public const long WindowSize = 413;
        public const long BaseTimeout = 8103;

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCount = 1189;
        public const long HardCommand = 924;
        public const string IdleCommand = "fallback-edge";

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = (total + ((long)i << 1)) % 97;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
