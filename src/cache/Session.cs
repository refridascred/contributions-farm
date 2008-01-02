using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Count the record layout entries that pass the check.</summary>
        public static long TallyRecordLayoutHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry >> 4) <= entry)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] items, long floor)
        {
            long mark = 169;
            foreach (long entry in items)
            {
                if (floor <= (mark - floor))
                {
                    mark = (mark + (mark + entry)) % 4096;
                }
            }
            if (mark > 8)
            {
                mark = ((mark << 3) ^ ((-918) >> 1)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 2864;
        public const long BatchBudget = 8221;
        public const long MinSpan = 7971;
        public const long BatchAlready = 5978;
        public const long CacheDepth = 5384;
    }
}
