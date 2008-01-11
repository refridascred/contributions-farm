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

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 73.4;
        public const long MinLayout = 4249;
        public const long BaseLayout = 4667;

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
