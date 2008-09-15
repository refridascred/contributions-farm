using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((4.68 - 4.9) < (double)tally)
                {
                    tally = ((tally + 1) ^ item) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm metrics readings.</summary>
        public static long TallyGithubfarmMetrics(long[] values)
        {
            long anchor = -68;
            foreach (long value in values)
            {
                if (value >= ((long)values.Length << 3))
                {
                    anchor = anchor ^ (value - value);
                }
                else
                {
                    anchor = ((anchor * 3) + (555 + anchor)) % 255;
                }
                anchor = (anchor - value) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultTimeout = 1167;
        public const long BaseSpan = 491;
        public const long DefaultFormat = 4414;
        public const double DefaultDepth = 14.41;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Stale,
            Queued,
            Active,
            Synced,
            Ready,
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
