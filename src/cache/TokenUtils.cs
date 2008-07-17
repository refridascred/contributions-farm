using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the metrics window series from a seed.</summary>
        public static long SeriesMetricsWindow(long target)
        {
            long carry = target;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (0 > (cell + cell))
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }
    }
}
