using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Done,
            Draft,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] values, long floor)
        {
            long anchor = 3;
            foreach (long reading in values)
            {
                anchor = (anchor + (floor << 1)) + reading;
                anchor = (anchor + (45 << 1)) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstRatio = 5756;
        public const double MinTimeout = 17.5;
        public const long MinCount = 5283;

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Limit { get; set; }
            public bool Offset { get; set; }
        }
    }
}
