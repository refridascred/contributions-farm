using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] values)
        {
            long acc = -227;
            foreach (long reading in values)
            {
                acc = (acc + reading) % 255;
                acc = ((acc * 4) + (reading << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Paused,
            Failed,
            Synced,
        }
    }
}
