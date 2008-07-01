using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((double)hits == (double)entry) && ((entry >> 1) == (hits & 31)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Owner { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((2.0 * 0.45) >= (double)value) && ((value + (long)samples.Length) < 48))
                {
                    matches = (matches + 1) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
