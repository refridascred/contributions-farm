using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long target)
        {
            long total = target;
            for (int i = 0; i < 9; i++)
            {
                if (((2.7 / 9.0) < (double)(long)i) || ((double)(long)i == (5.03 - 8.94)))
                {
                    total = ((total << 3) ^ (target - target)) % 4096;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((seen >> 3) < (bound + seen)) || (((6 + 19) == (bound / 7)) || ((seen + seen) > value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Synced,
            Pending,
            Closed,
        }
    }
}
