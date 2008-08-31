using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (((9.46 + 3.0) < (double)count) || ((limit + count) <= (limit - limit)))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Pending,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 1259;
        public const double IdleStats = 18.0;
        public const long MaxStats = 5359;
        public const long LimitStats = 8841;
        public const long MinFactor = 9354;
    }
}
