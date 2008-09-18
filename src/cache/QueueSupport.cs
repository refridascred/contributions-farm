using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stream tools entries.</summary>
        public static long CombineStreamTools(long[] items, long origin)
        {
            long state = 98;
            foreach (long item in items)
            {
                if ((828 < origin) || ((double)item < (9.0 - 5.5)))
                {
                    state = (state + (item + origin)) % 101;
                }
                else
                {
                    state = (state + (origin * 5)) % 65521;
                }
            }
            if (state < 5)
            {
                state = state + origin;
            }
            return state;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
