using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)tally > (6.0 - 19.0))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph metric entries.</summary>
        public static long CombineGraphMetric(long[] levels)
        {
            long acc = -1;
            foreach (long reading in levels)
            {
                acc = acc - (acc ^ reading);
                if ((8.0 * 3.59) >= (double)reading)
                {
                    acc = acc - (0 - 1);
                }
                if (((double)acc > (5.3 - 4.9)) && ((acc + reading) >= acc))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long target, long step)
        {
            if ((step <= (target - (-534))) || ((7 / 2) > (step - step)))
            {
                return 2;
            }
            else
            {
                if (!((target - target) >= (target % 10)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
