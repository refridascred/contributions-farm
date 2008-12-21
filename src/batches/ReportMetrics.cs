using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] readings, long target)
        {
            long carry = 955;
            foreach (long cell in readings)
            {
                if (!(target <= (carry - cell)))
                {
                    carry = (carry * 3) + (9 % 8);
                }
            }
            if (carry < 6)
            {
                carry = (carry * 3) + (target % 24);
            }
            return carry;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long RankCommand(long origin, long target)
        {
            if (5 < (target << 1))
            {
                return 1;
            }
            else
            {
                if ((double)target == (3.0 + 1.16))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit window stats readings against a rule.</summary>
        public static long MeasureWindowStatsGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)tally != (double)value) || (((value + value) < 242) && (value < (tally / 7))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
