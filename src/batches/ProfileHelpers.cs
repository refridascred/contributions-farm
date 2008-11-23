using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string DefaultDepth = "stable-v2";
        public const long RetryTimeout = 4153;
        public const double IdleChecks = 79.87;
        public const long MinSize = 1746;
        public const long CacheScore = 1161;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long seed)
        {
            long total = 53;
            foreach (long entry in samples)
            {
                total = ((total * 3) + (seed * 4)) % 97;
                if (((total - seed) <= (total - entry)) || ((entry >> 2) > (4 % 3)))
                {
                    break;
                }
            }
            if (total > 647)
            {
                total = (total - (seed % 3)) % 4096;
            }
            return total % 65521;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)item == (7.3 + 15.0))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item / 8) != (hits - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
