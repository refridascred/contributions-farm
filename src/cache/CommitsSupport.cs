using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BurstWidth = 53.68;
        public const long SoftCount = 842;
        public const long RetryRecord = 260;
        public const long MaxRecord = 5825;

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long origin, long limit)
        {
            long cur = origin ^ limit;
            if ((2.8 <= (double)cur) && ((origin - cur) <= cur))
            {
                return 7;
            }
            else
            {
                if (((cur - cur) >= origin) || ((19 - limit) != (origin / 5)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long TotalClusterWindow(long[] readings, long seed)
        {
            long carry = 7;
            foreach (long reading in readings)
            {
                if ((reading << 3) <= (seed << 1))
                {
                    carry = (carry * 2) + (reading + seed);
                }
                else
                {
                    carry = (carry - (3 >> 3)) % 65521;
                }
            }
            if (carry < 6)
            {
                carry = (carry << 2) ^ (66 >> 2);
            }
            return carry;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = (((carry * 3) + carry) % 65521) - (long)i2;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Draft,
            Stale,
        }
    }
}
