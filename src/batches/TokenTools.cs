using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next cluster notes value from a seed.</summary>
        public static long SeriesClusterNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 5; i++)
            {
                total = (total * 3) + (59 + total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long AuditTokenCommandMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)step <= (6.7 - 4.5))
                {
                    tally = (tally + 1) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell + matches) >= (matches << 2))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
