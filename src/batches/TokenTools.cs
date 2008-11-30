using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Pending,
            Done,
            Failed,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - hits) >= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
