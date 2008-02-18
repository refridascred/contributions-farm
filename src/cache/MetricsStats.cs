using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long origin, long seed)
        {
            if ((2.4 - 9.0) < (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Closed,
            New,
            Dropped,
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] values)
        {
            long mix = 2;
            foreach (long entry in values)
            {
                if (!((entry + entry) < (mix ^ mix)))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
