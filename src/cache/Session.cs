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

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = (result - (target + result)) % 97;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MaxDepth = "open-1";
        public const long CacheBudget = 859;
        public const double MaxReport = 78.76;
        public const string StepReport = "legacy-1";
        public const long WindowReport = 1171;
    }
}
