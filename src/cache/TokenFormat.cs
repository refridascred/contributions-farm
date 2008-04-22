using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 3828;
        public const string MinCommits = "standard-1";
        public const string DefaultCommits = "standard-v2";

        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long limit)
        {
            if ((offset >> 3) == (offset / 2))
            {
                return 2;
            }
            else
            {
                if (!(38 > (offset / 6)))
                {
                    return 6;
                }
                else
                {
                    if ((offset - 483) != (offset - 57))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Dropped,
            Closed,
            Active,
            Retry,
        }
    }
}
