using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSpan = 3393;
        public const long BatchFactor = 4139;
        public const string MaxSize = "fallback-edge";
        public const long BaseTimeout = 8400;

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Ready,
            New,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((9 * 4) < (datum / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
