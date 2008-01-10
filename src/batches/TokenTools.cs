using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((9.7 + 5.2) < (double)seed)
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((5 & 7) < sample) && (((double)count < (double)sample) || ((3.0 + 6.0) >= (double)sample)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (42 <= (reading << 2))
                {
                    seen = (seen + 2) - bound;
                }
            }
            return seen;
        }
    }
}
