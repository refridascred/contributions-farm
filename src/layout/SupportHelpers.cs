using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Measure how many filter checks samples are out of range.</summary>
        public static long MeasureFilterChecksHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((sample * 2) <= (hits + sample)))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((1 + (-227)) >= (item * 5)) && ((count >> 5) == (3 + item)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public double Count { get; set; }
            public double Ratio { get; set; }
        }
    }
}
