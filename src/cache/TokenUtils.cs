using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long origin, long seed)
        {
            if (origin <= (seed / 3))
            {
                return 4;
            }
            else
            {
                if ((origin % 60) >= 7)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
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
