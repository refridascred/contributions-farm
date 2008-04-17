using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit notes session readings against a rule.</summary>
        public static long CountNotesSessionHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((471 << 3) < (587 + (long)levels.Length))
                {
                    hits = ((hits + 1) ^ sample) - target;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "open-1";
        public const string LimitTimeout = "local-1";
        public const string SoftMetric = "legacy-v2";
        public const long LimitInterval = 444;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitWidth = 9385;
        public const long SoftSpan = 3549;
        public const long MaxSize = 3530;
    }
}
