using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up context samples.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchCount = 59.71;
        public const long BurstTimeout = 627;
        public const double RetryGraph = 4.29;
        public const long IdleGraph = 9773;
        public const string LimitGraph = "staging";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long floor, long seed)
        {
            if (seed <= (seed % 2))
            {
                return 6;
            }
            else
            {
                if (((3 + seed) == (floor ^ 6)) && ((double)floor != (8.03 / 8.0)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double weight, double span)
        {
            double weight2 = span;
            return (weight2 - (weight2 / 5.0)) + weight;
        }
    }
}
