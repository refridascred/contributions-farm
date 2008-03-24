using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Failed,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)seed == (4.56 / 9.0))
                {
                    break;
                }
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
