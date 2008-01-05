using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit notes support readings against a rule.</summary>
        public static long AuditNotesSupportHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((6.9 * 0.43) < (double)count)
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (tally > (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((tally << 2) > (datum >> 5)) && (536 >= datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
