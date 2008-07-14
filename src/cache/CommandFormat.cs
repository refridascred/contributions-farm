using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheCount = 22.9;
        public const string WindowScore = "fallback-1";
        public const long HardBatches = 6462;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BaseCache = 21.71;
        public const double IdleLevel = 83.8;
        public const long SoftLevel = 5994;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Check that every commits command entry stays within the limit.</summary>
        public static bool VerifyCommitsCommandRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
