using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Region { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] items, long offset)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 5188;
        public const long LimitPayload = 9401;
        public const string BaseInterval = "primary-1";
        public const string MinPayload = "staging-edge";
    }
}
