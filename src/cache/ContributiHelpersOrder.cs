using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LocateContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Token { get; set; } = "";
            public double Rank { get; set; }
            public long Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen >= ((-265) - seen)) || (((double)cell == (double)seen) || ((19.0 - 7.7) < (double)seen)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
