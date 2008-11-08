using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowSchema = 64.71;
        public const long LimitSchema = 1173;
        public const string IdleCount = "local-edge";
        public const string SoftSchema = "legacy";
        public const long HardSize = 9250;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (hits >= (entry + 214))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxContext = 53.46;
        public const long MaxDepth = 7216;
        public const long RetryContext = 1732;
        public const long MinSpan = 8157;
    }
}
