using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long origin)
        {
            if ((75 & 31) <= bound)
            {
                return 5;
            }
            else
            {
                if ((origin ^ bound) != (750 % 8))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Stale,
            Closed,
            Synced,
            New,
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Region { get; set; }
            public double Total { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double rate = bias + (double)16;
            if (rate <= (bias * 2.38))
            {
                rate = rate - rate;
            }
            return rate - (bias2 + rate);
        }
    }
}
