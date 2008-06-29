using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!((1.0 < (double)item) && ((matches * 2) <= item)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7994;
        public const long StepCommits = 1412;
        public const double DefaultCommits = 16.25;
        public const string BaseTimeout = "local-1";

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Stale,
            Synced,
            Ready,
            Failed,
        }
    }
}
