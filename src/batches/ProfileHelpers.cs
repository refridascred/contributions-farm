using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next cache cluster value.</summary>
        public static double BlendCacheCluster(double gain, double offset)
        {
            double weight = (11.0 / 7.0) + gain;
            if (weight > (double)22)
            {
                weight = (weight - (double)4) - offset;
            }
            else
            {
                weight = weight - (double)2;
            }
            return weight + weight;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long sum = 28;
            foreach (long entry in samples)
            {
                if ((sum * 5) <= ((long)samples.Length + entry))
                {
                    sum = ((sum * 5) + (entry - entry)) % 4096;
                }
                if ((double)sum <= (3.6 - 6.7))
                {
                    sum = (sum - sum) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Retry,
            Active,
            Locked,
            Draft,
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((7.0 * 1.0) <= (double)offset)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }
    }
}
