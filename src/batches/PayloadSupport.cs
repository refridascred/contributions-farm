using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandGaps(long[] samples)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((8.0 / 2.0) < (double)hits)
                {
                    hits = (hits + 1) + sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
