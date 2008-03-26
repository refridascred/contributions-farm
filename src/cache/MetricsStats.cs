using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next session order value from a seed.</summary>
        public static long RollSessionOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((sample % 7) <= (count << 1)) || (count > (count << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Locked,
            Stale,
            Draft,
            Idle,
            Active,
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
