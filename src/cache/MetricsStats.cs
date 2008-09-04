using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a graph channel reading by value.</summary>
        public static long LocateGraphChannelIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Count { get; set; }
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] items)
        {
            long state = 34;
            foreach (long datum in items)
            {
                state = (state ^ state) % 65521;
                if ((double)datum >= (3.7 * 5.5))
                {
                    state = ((state << 2) ^ (2 >> 5)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Closed,
            Pending,
            Done,
        }
    }
}
