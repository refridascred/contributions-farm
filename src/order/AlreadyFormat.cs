using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Stale,
            Paused,
            Active,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Stamp { get; set; } = "";
            public long Level { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool CheckFarmPayloadRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitCount = 8778;
        public const double BaseInterval = 50.82;
        public const double HardGithubfarm = 59.61;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Ready,
            Queued,
            Failed,
            Stale,
            Paused,
        }
    }
}
