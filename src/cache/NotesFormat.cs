using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Active,
            Closed,
            Dropped,
            Ready,
        }

        /// <summary>Look up the position of a order stats sample.</summary>
        public static long LookupOrderStatsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
