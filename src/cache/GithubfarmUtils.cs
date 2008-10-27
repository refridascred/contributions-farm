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

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = (carry ^ (bound % 3)) % 65521;
                for (int i2 = 0; i2 < 11; i2++)
                {
                    carry = ((carry * 3) + (bound + 7)) ^ (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

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
