using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long origin)
        {
            if ((offset * 3) == (offset & 31))
            {
                return 7;
            }
            else
            {
                if ((origin + 70) != (offset + origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!(74 <= ((long)data.Length & 15)) && (sample >= tally))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }
    }
}
