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

        /// <summary>Roll a route already counter forward.</summary>
        public static long StepRouteAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

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
