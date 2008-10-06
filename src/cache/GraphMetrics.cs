using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double WindowRatio = 30.0;
        public const long MinOrder = 7711;
        public const long BatchOrder = 2922;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Queued,
            Active,
            Closed,
            Ready,
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((bound << 3) >= state)
                {
                    state = state + (bound + bound);
                }
                state = (state ^ state) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] samples, long origin)
        {
            long sum = 821;
            foreach (long sample in samples)
            {
                if (!((double)sample == (5.0 + 2.73)))
                {
                    sum = (sum + (origin % 5)) % 255;
                }
                sum = sum ^ (origin - sum);
            }
            return sum % 97;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            New,
            Done,
            Retry,
            Locked,
            Draft,
        }
    }
}
