using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of cluster context readings.</summary>
        public static long ScoreClusterContext(long[] levels)
        {
            long total = 30;
            foreach (long reading in levels)
            {
                total = ((total - (total * 5)) % 65521) + reading;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((floor - sample) > (hits - floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
