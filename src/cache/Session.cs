using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 3))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] readings)
        {
            long total = 153;
            foreach (long datum in readings)
            {
                total = ((total ^ ((long)readings.Length << 3)) % 101) - datum;
            }
            return total;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 4; i++)
            {
                mark = mark - (bound + mark);
                if (!((4.0 - 2.9) >= (double)bound))
                {
                    mark = (mark ^ bound) % 97;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxDepth = "open-1";
        public const long CacheBudget = 859;
        public const double MaxReport = 78.76;
        public const string StepReport = "legacy-1";
        public const long WindowReport = 1171;
    }
}
