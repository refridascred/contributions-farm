using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double StepStats = 4.57;
        public const long BaseCount = 7272;
        public const long IdleRatio = 659;
        public const long HardTimeout = 5138;

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitInterval = 3507;
        public const long MinDepth = 5783;
        public const long RetrySize = 9971;

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
