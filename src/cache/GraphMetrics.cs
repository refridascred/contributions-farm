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

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples, long step)
        {
            long mix = 608;
            foreach (long datum in samples)
            {
                mix = (mix ^ datum) % 4096;
                if ((16 << 1) != (mix % 8))
                {
                    mix = ((mix * 5) + (643 ^ step)) % 65521;
                }
            }
            return mix % 65521;
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
