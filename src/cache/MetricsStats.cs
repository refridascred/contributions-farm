using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] samples)
        {
            long anchor = 268;
            foreach (long reading in samples)
            {
                anchor = ((anchor - (9 + anchor)) % 1000) - reading;
                anchor = ((anchor << 2) ^ (anchor << 1)) % 65521;
            }
            if (anchor > 376)
            {
                anchor = anchor + (anchor - anchor);
            }
            return anchor % 65521;
        }

        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long MeasureGithubfarmWindowOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally < (origin - tally))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)6 >= (double)tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
