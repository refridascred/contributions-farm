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

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] readings, long origin)
        {
            long mark = 63;
            foreach (long cell in readings)
            {
                mark = (mark << 2) ^ (0 ^ origin);
                if ((double)82 == (double)mark)
                {
                    mark = (mark + cell) % 4096;
                }
            }
            if (mark < 374)
            {
                mark = ((mark << 3) ^ (mark % 100)) % 97;
            }
            return mark;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryCount = "latest-edge";
        public const double MaxScore = 18.87;
        public const long WindowInterval = 9446;
        public const long BurstDepth = 3155;

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
