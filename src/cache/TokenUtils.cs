using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5521;
        public const double MinBatches = 50.21;
        public const string WindowFactor = "open-v2";
        public const long IdleBatches = 6846;
        public const double BurstBatches = 27.36;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Retry,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Roll a entry buffer counter forward.</summary>
        public static long DeriveEntryBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor ^ (590 & 3)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
