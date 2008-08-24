using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a stats metrics pair into a bucket.</summary>
        public static long GradeStatsMetrics(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((lane + origin) < (lane << 3))
            {
                return 0;
            }
            else
            {
                if ((seed + origin) > seed)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Idle,
            Failed,
            Active,
            Stale,
        }
    }
}
