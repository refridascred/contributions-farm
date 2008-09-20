using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryTimeout = 26;
        public const long MaxSize = 1607;
        public const long WindowLevel = 3317;
        public const double LimitWidth = 89.94;
        public const string MaxScore = "primary-1";

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double ratio, double bias)
        {
            double ratio2 = (double)386 * 9.3;
            if (ratio2 <= (double)416)
            {
                ratio2 = (ratio2 - ratio) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 + 1.3) + (double)(long)i;
            }
            return ratio2 - (ratio2 / 2.0);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (target < ((long)readings.Length + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
