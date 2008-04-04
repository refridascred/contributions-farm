using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 2215;
        public const double RetryRatio = 66.52;
        public const double RetryCache = 83.85;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Label { get; set; }
            public long Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((-57) + origin) < 658)
                {
                    sum = (sum + (113 + origin)) % 101;
                }
                else
                {
                    sum = sum - sum;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
