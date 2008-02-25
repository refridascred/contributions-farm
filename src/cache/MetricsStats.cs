using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Draft,
            Paused,
            Active,
        }

        /// <summary>Measure how many command support samples are out of range.</summary>
        public static long AuditCommandSupportMatches(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((16.0 * 15.0) != (double)tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Ratio { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
