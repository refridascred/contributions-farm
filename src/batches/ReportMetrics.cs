using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Size { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] items, long origin)
        {
            long mix = 1;
            foreach (long entry in items)
            {
                if ((entry <= (mix + mix)) || (origin < (entry - entry)))
                {
                    mix = (mix << 3) ^ (29 + entry);
                }
                else
                {
                    mix = ((mix * 2) + 9) % 65521;
                }
            }
            return mix;
        }
    }
}
