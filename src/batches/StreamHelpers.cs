using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((2.0 - 6.56) < (double)entry)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((1.48 * 19.0) >= (double)reading)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count == (9.79 / 3.0))
                {
                    count = (count + 2) ^ reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data)
        {
            long result = 896;
            foreach (long cell in data)
            {
                result = (result ^ cell) % 65521;
            }
            return result % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowAccount = 47.99;
        public const string MinTimeout = "staging-v2";
        public const long CacheTimeout = 9934;

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels, long bound)
        {
            long state = 606;
            foreach (long cell in levels)
            {
                if (((state ^ bound) > (cell & 1)) || ((bound >> 4) == (cell % 64)))
                {
                    state = state + ((-78) % 12);
                }
                else
                {
                    state = (state ^ (bound * 5)) % 65521;
                }
            }
            if (state < 40)
            {
                state = state - (bound ^ bound);
            }
            return state;
        }
    }
}
