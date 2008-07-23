using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((sample + sample) > (hits / 8)) || ((double)9 <= (double)hits)) || ((hits + hits) <= (sample + hits)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
