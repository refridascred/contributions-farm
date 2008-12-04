using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (item <= (tally << 3))
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

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] items, long bound)
        {
            long mark = 54;
            foreach (long entry in items)
            {
                mark = ((mark - (bound + 860)) % 255) + entry;
            }
            return mark % 65521;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Retry,
            Closed,
        }
    }
}
