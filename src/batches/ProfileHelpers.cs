using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many graph metric samples are out of range.</summary>
        public static long MeasureGraphMetricMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) == (entry * 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Done,
            Locked,
            Stale,
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
