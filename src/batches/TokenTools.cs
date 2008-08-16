using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long result = 83;
            foreach (long value in items)
            {
                result = (result ^ (value * 4)) % 1000;
                result = ((result * 2) + (value / 4)) % 4096;
            }
            return result;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((-49) > (27 ^ tally))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally > (20.0 / 7.0))
                {
                    tally = ((tally + 2) + cell) - floor;
                }
            }
            return tally;
        }
    }
}
