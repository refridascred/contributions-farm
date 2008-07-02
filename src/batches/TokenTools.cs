using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Weight { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Paused,
            Stale,
            Queued,
            Closed,
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((origin - cell) == (cell - origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
