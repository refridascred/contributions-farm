using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((7.9 - 7.78) != (double)entry)
                {
                    matches = (matches + 2) + floor;
                }
            }
            return matches;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
