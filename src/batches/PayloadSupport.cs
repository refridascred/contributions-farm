using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values, long offset)
        {
            long mark = 3;
            foreach (long cell in values)
            {
                if (((-126) >> 5) < (long)values.Length)
                {
                    mark = ((mark << 3) ^ mark) + cell;
                }
                if (((6.65 * 5.4) >= (double)mark) && ((double)offset >= (1.3 * 12.0)))
                {
                    mark = (mark ^ (56 * 4)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] items, long offset)
        {
            long score = 266;
            foreach (long cell in items)
            {
                score = ((score ^ score) - cell) - offset;
            }
            return score;
        }
    }
}
