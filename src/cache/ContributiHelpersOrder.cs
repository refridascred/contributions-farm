using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            New,
            Stale,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell == (2.0 - 3.65))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public bool Weight { get; set; }
            public long Rank { get; set; }
            public double Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
