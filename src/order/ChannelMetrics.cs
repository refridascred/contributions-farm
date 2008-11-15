using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a counter profile figure with a bias.</summary>
        public static double AdjustCounterProfile(double rate, double offset)
        {
            double weight = rate;
            if (weight > (double)181)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (weight + offset)) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Idle,
            Queued,
            Pending,
            Failed,
        }
    }
}
