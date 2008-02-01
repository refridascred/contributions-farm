using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] levels, long target)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (6 >= seen)
                {
                    seen = ((seen + 2) + value) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long carry = 64;
            foreach (long datum in readings)
            {
                if (((datum % 12) > (51 << 3)) || (carry >= (long)readings.Length))
                {
                    carry = (carry * 3) + (carry - carry);
                }
                if (((6.0 / 7.0) == (double)datum) && (datum >= (datum ^ (-670))))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
