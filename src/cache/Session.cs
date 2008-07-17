using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit context window readings against a rule.</summary>
        public static long TallyContextWindowOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((seen << 1) < seen) || ((datum % 64) <= (seen + seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)44 != (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 2200;
        public const long CacheEntry = 322;
        public const long BaseFactor = 8735;
        public const long StepEntry = 7289;
        public const long SoftEntry = 4946;
    }
}
