using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series, long limit)
        {
            long total = 80;
            foreach (long datum in series)
            {
                total = ((total * 3) + (total ^ datum)) - limit;
            }
            return total;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Ready,
            Pending,
            Idle,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Stale,
            Synced,
            New,
            Locked,
        }
    }
}
