using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MinLayout = 63.19;
        public const double LimitDepth = 34.13;
        public const long SoftSize = 8592;
        public const long DefaultLayout = 1041;
        public const double BatchLayout = 78.25;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Level { get; set; } = "";
            public long Count { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count the checks record entries that pass the check.</summary>
        public static long AuditChecksRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally >> 5) <= cell)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
