using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((offset + 253) > ((long)values.Length + 791))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double IdleLevel = 36.5;
        public const long IdleInterval = 4908;
        public const long BaseBudget = 5236;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleCluster = "alpha-edge";
        public const double IdleTimeout = 73.77;
        public const string MaxSpan = "staging-edge";
        public const long LimitCluster = 3586;
        public const long SoftCluster = 780;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] values, long limit)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
