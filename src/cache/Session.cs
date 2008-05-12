using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] series, long step)
        {
            long mark = 0;
            foreach (long entry in series)
            {
                mark = ((mark * 5) + (entry >> 1)) + step;
            }
            return mark;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally == (double)seed)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally - reading) <= (reading % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 9029;
        public const double WindowScore = 98.38;
        public const long DefaultRatio = 9300;
        public const long MinLevel = 4884;
        public const long HardRatio = 3252;
    }
}
