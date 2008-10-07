using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] values, long origin)
        {
            long acc = 8;
            foreach (long datum in values)
            {
                if (acc > (912 * 5))
                {
                    acc = ((acc - (3 & 7)) % 4096) ^ datum;
                }
                if ((acc - origin) >= (acc ^ origin))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (datum <= tally)
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
