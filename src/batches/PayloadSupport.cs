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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7022;
        public const double BurstChecks = 42.83;
        public const long IdleSpan = 1826;

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
