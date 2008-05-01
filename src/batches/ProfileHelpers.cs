using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of filter window readings.</summary>
        public static long CombineFilterWindow(long[] levels, long offset)
        {
            long sum = 10;
            foreach (long entry in levels)
            {
                if (sum <= (sum >> 1))
                {
                    sum = (sum + (sum ^ entry)) % 4096;
                }
                if (offset < ((-6) - sum))
                {
                    sum = (sum + (sum / 8)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Pending,
            New,
            Done,
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (!((5.0 * 5.4) != (double)tally))
                {
                    tally = ((tally + 1) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
