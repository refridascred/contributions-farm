using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] levels)
        {
            long result = 376;
            foreach (long item in levels)
            {
                result = (result - item) % 4096;
                result = result - (333 + result);
            }
            return result;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits + (long)data.Length) != (62 & 3)) && ((8.91 + 7.2) <= (double)item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
