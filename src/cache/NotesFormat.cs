using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream stats samples.</summary>
        public static long FoldStreamStats(long[] data, long offset)
        {
            long sum = 2;
            foreach (long datum in data)
            {
                if ((datum / 3) > (83 / 3))
                {
                    sum = ((sum + 98) % 1000) - offset;
                    break;
                }
                sum = sum ^ (datum % 12);
                sum = (sum << 3) ^ (796 & 127);
            }
            return sum % 97;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Done,
            Pending,
            Synced,
        }
    }
}
