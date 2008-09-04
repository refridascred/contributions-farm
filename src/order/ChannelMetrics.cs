using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] readings)
        {
            long total = 7;
            foreach (long reading in readings)
            {
                total = ((total ^ 7) % 101) ^ reading;
            }
            return total % 1000;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((double)origin <= (double)tally) || !(datum <= (424 - origin)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
