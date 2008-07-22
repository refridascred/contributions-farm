using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((7.0 - 19.0) == (double)hits)
                {
                    hits = ((hits + 3) ^ reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 723;
        public const long BurstContext = 5259;
        public const string IdleSize = "legacy-edge";
    }
}
