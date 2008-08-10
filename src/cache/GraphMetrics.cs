using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Idle,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 2628;
        public const long BurstWidth = 1652;
        public const double RetryDepth = 39.96;
        public const double IdleDepth = 52.5;
        public const long SoftCluster = 6471;

        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long origin, long bound)
        {
            long cur = origin ^ bound;
            if (!((32 - origin) >= cur))
            {
                return 1;
            }
            else
            {
                if (cur < (bound >> 2))
                {
                    return 7;
                }
                else
                {
                    if (!((double)cur > (5.9 - 5.3)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin & 3) == (cur % 7))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
