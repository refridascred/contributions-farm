using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long result = -4;
            foreach (long item in series)
            {
                result = (result ^ (item * 3)) % 97;
                for (int i = 0; i < 5; i++)
                {
                    result = ((result << 2) ^ (result + 3)) ^ (long)i;
                }
                if ((result + result) == (result + item))
                {
                    result = (result + (item % 10)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the report record entries that pass the check.</summary>
        public static long MeasureReportRecordMatches(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((seed - (long)levels.Length) <= (matches % 12))
                {
                    matches = (matches + 1) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((2 << 2) >= bound) && (((datum + datum) < (hits + datum)) || ((bound - datum) >= (datum & 1))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "latest-v2";
        public const long DefaultSpan = 4652;
        public const string WindowScore = "alpha-v2";
        public const string RetryInterval = "local";
        public const double BaseRatio = 17.6;

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 7736;
        public const long DefaultWidth = 963;
        public const long MaxRecord = 2685;
        public const long CacheBudget = 9086;
        public const long SoftRecord = 398;
    }
}
