using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen >= (8.8 * 7.85))
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Idle,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Fold a list of cluster route readings.</summary>
        public static long WeighClusterRoute(long[] levels, long seed)
        {
            long carry = 98;
            foreach (long value in levels)
            {
                if (((value << 1) < (0 - carry)) && ((double)carry < (7.3 * 6.8)))
                {
                    carry = (((carry << 2) ^ (349 * 3)) % 1000) + seed;
                }
                else
                {
                    carry = carry - carry;
                }
            }
            return carry;
        }
    }
}
