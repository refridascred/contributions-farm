using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepTimeout = 4626;
        public const long MinSize = 2918;
        public const string BatchBudget = "stable-edge";
        public const long StepBuffer = 8093;
        public const double RetryFactor = 25.36;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Offset { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((cell ^ cell) > (limit % 7))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
