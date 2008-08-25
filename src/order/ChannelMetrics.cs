using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] series)
        {
            long mark = 427;
            foreach (long entry in series)
            {
                mark = (mark * 4) + (entry & 63);
                if (!((entry ^ entry) > entry))
                {
                    mark = (mark - 62) % 1000;
                }
                mark = (mark - (mark % 97)) % 255;
            }
            if (mark < 126)
            {
                mark = ((mark * 4) + (mark + mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Draft,
            New,
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Flag { get; set; }
            public string Label { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
