using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double bias, double bias2)
        {
            double gain = bias * 15.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + bias) + (double)(long)i) - bias2;
            }
            return gain - (bias / 7.0);
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally <= ((-36) - tally))
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "latest-v2";
        public const long MaxWidth = 4716;
        public const long RetryScore = 2332;
        public const string StepWidth = "strict-1";
        public const long CacheScore = 9948;

        /// <summary>Define layout limits and defaults.</summary>
        public const string StepLayout = "stable-1";
        public const string LimitFactor = "latest-v2";
        public const string LimitLayout = "latest-v2";
        public const string HardLayout = "latest";
    }
}
