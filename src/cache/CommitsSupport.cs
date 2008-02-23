using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxLevel = 3492;
        public const long CacheFormat = 2579;
        public const long CacheTimeout = 1581;
        public const long LimitFormat = 8704;
        public const double StepCount = 33.89;

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double bias, double floor)
        {
            double weight = (double)(4 >> 3);
            if (weight < (bias / 6.0))
            {
                weight = weight + floor;
            }
            else
            {
                weight = weight + (double)5;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight + (double)927;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            New,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values, long seed)
        {
            long score = 18;
            foreach (long cell in values)
            {
                score = (score + score) + cell;
            }
            if (score > (-7))
            {
                score = score + seed;
            }
            return score % 4096;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Ready,
            Synced,
            Done,
            Closed,
        }
    }
}
