using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long total = 19;
            foreach (long entry in levels)
            {
                total = ((total * 4) + (5 * 4)) % 65521;
                if ((entry % 100) > (entry << 1))
                {
                    break;
                }
            }
            if (total > 50)
            {
                total = (total * 4) + total;
            }
            return total % 1000;
        }

        /// <summary>Find the first route command entry that matches the target.</summary>
        public static long SeekRouteCommandIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((floor << 3) < (value & 1))
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
    }
}
