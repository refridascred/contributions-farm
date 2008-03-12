using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(15 < (sample - count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) <= (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
