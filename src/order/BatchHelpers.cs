using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up buffer stream samples.</summary>
        public static long CompareBufferStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 5377;
        public const long LimitDepth = 3606;
        public const double BatchRatio = 36.18;
        public const long DefaultCommits = 2160;
        public const long BaseCommits = 935;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Closed,
            New,
        }
    }
}
