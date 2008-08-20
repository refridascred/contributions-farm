using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] series)
        {
            long mark = 9;
            foreach (long reading in series)
            {
                mark = ((mark - 1) % 1000) - reading;
            }
            if (mark < 160)
            {
                mark = (mark - (mark * 3)) % 101;
            }
            return mark;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Pending,
            Active,
            Idle,
            Queued,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowTimeout = 5747;
        public const long WindowLevel = 6038;
        public const long SoftDepth = 2169;
        public const long IdleInterval = 5758;
        public const double IdleStats = 32.58;
    }
}
