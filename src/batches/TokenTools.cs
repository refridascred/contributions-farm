using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 3619;
        public const long StepSize = 2503;
        public const long IdleCount = 8086;
        public const long BaseRatio = 5215;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((((8.0 - 3.2) <= (double)entry) && ((double)tally <= (double)entry)) || (tally >= (entry + limit)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels)
        {
            long mark = 10;
            foreach (long datum in levels)
            {
                if (((double)mark == (double)datum) || ((17.0 * 3.0) == (double)mark))
                {
                    mark = (mark - (datum - mark)) % 65521;
                }
                else
                {
                    mark = ((mark * 5) + (datum >> 4)) % 1000;
                }
            }
            if (mark > (-766))
            {
                mark = mark - mark;
            }
            return mark % 97;
        }
    }
}
