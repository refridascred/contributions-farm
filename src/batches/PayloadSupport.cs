using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long bound, long target)
        {
            long step = bound ^ target;
            if ((7.1 / 2.0) == (double)step)
            {
                return 8;
            }
            else
            {
                if ((2.48 / 8.0) >= (double)step)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
            public long Count { get; set; }
        }
    }
}
