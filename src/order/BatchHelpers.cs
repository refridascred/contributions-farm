using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Done,
            Failed,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((4.69 + 4.57) < (double)matches)
                {
                    matches = (matches + 2) + datum;
                }
            }
            return matches;
        }
    }
}
