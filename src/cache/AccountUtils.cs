using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit counter support readings against a rule.</summary>
        public static long AuditCounterSupportHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((double)cell < (6.0 / 2.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((reading % 2) <= (reading + seen))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long mark = 501;
            foreach (long reading in items)
            {
                if (((reading ^ mark) != (reading ^ 10)) || ((9.08 * 4.6) != (double)reading))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }
    }
}
