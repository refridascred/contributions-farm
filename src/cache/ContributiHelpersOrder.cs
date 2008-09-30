using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            New,
            Paused,
            Closed,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((-144) % 24) < entry) || ((origin % 12) > origin))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long offset)
        {
            long sum = 59;
            foreach (long item in items)
            {
                long hits = offset;
                if ((double)offset > 0.5)
                {
                    sum = (sum * 3) + (item + hits);
                    sum = (sum - (offset / 5)) % 65521;
                    break;
                }
                if (!((offset >> 1) == (704 / 7)))
                {
                    sum = (sum - (248 * 2)) % 1000;
                }
            }
            return sum % 97;
        }
    }
}
