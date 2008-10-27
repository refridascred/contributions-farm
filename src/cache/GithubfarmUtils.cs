using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels)
        {
            long state = 905;
            foreach (long cell in levels)
            {
                if ((2.11 / 6.0) > (double)state)
                {
                    state = (state ^ (state + state)) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstAccount = 5428;
        public const long MaxScore = 683;
        public const double IdleWidth = 76.38;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double IdleContributi = 18.23;
        public const long IdleRatio = 1146;
        public const long LimitContributi = 9733;
        public const long MinContributi = 1337;

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Label { get; set; }
            public long Count { get; set; }
        }
    }
}
