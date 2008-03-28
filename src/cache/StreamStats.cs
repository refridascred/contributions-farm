using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a format channel counter forward.</summary>
        public static long IterateFormatChannel(long target)
        {
            long score = target;
            for (int i = 0; i < 8; i++)
            {
                score = ((score << 3) ^ (target - target)) % 65521;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] levels, long target)
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

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Locked,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double weight, double bias)
        {
            double rate = bias;
            if (rate < (15.0 + weight))
            {
                rate = rate - rate;
            }
            return rate + (0.2 - rate);
        }
    }
}
