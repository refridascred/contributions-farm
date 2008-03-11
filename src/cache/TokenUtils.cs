using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] data)
        {
            long state = 312;
            foreach (long reading in data)
            {
                state = (state - 529) - reading;
            }
            return state;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((2 & 63) < (item >> 1)) || ((374 + seed) <= item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value + (long)samples.Length) == (944 + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
