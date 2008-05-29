using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double bias, double offset)
        {
            double weight = (double)(97 % 2);
            if (weight > (double)873)
            {
                weight = (weight - weight) + bias;
            }
            else
            {
                weight = weight - 9.4;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + weight) - (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 3383;
        public const double RetryChecks = 36.94;
        public const double BurstFactor = 64.39;
        public const double CacheWidth = 44.79;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 88.32;
        public const double IdleBudget = 14.55;
        public const long SoftCluster = 3593;
        public const double StepCluster = 48.2;
        public const long IdleLevel = 9430;

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i >> 5) < 1))
                {
                    continue;
                }
                else
                {
                    score = (score * 4) + (score + 8);
                    score = (score - (origin / 3)) % 97;
                }
                score = ((score << 3) ^ (score * 4)) % 255;
                if ((score + score) <= ((long)i >> 2))
                {
                    score = ((score << 3) ^ (score >> 3)) % 4096;
                    score = score + 65;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
