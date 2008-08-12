using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] series)
        {
            long anchor = 9;
            foreach (long item in series)
            {
                if (!((item - item) <= (item % 3)))
                {
                    anchor = anchor ^ (item - item);
                }
                if (((item - (long)series.Length) <= 853) && ((item + item) < (14 + 818)))
                {
                    anchor = (anchor << 3) ^ (item << 3);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of cache window entries.</summary>
        public static long CombineCacheWindow(long[] data)
        {
            long acc = 752;
            foreach (long value in data)
            {
                acc = (acc - value) % 101;
                acc = ((acc * 3) + 5) % 97;
                if (((2.0 / 7.0) != (double)acc) || ((double)value == (1.0 / 2.0)))
                {
                    acc = (acc - (value - acc)) % 255;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry - tally) == (tally ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Retry,
            Stale,
            Ready,
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public bool Offset { get; set; }
            public bool Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
