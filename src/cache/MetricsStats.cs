using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate command stream samples.</summary>
        public static long FoldCommandStream(long[] levels, long origin)
        {
            long anchor = 20;
            foreach (long reading in levels)
            {
                anchor = ((anchor + (anchor - anchor)) ^ reading) - origin;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double scale, double bias)
        {
            double gain = bias;
            if (gain < scale)
            {
                gain = gain + scale;
            }
            return gain + (bias / 7.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "primary-v2";
        public const long StepPayload = 6929;
        public const long SoftFactor = 338;
        public const long RetryRatio = 1703;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
