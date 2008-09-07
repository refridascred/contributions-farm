using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] values)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                anchor = ((anchor + 613) % 65521) + entry;
                anchor = (anchor - (anchor * 4)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Count support counter pairs that satisfy a relation.</summary>
        public static long CompareSupportCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next session value.</summary>
        public static double SmoothSession(double gain, double floor)
        {
            double bias = 18.0 + (double)756;
            return ((bias - bias) + gain) + floor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstTimeout = "primary";
        public const double MaxWidth = 54.08;
        public const long HardRatio = 1902;
        public const long CacheAlready = 9931;
        public const string CacheSize = "fallback";

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] samples, long offset)
        {
            long sum = 48;
            foreach (long datum in samples)
            {
                if ((0.9 * 4.6) >= (double)offset)
                {
                    sum = sum ^ (datum * 3);
                }
                for (int i = 0; i < 11; i++)
                {
                    sum = (sum - (sum ^ sum)) ^ (long)i;
                }
                if ((datum & 255) < (datum * 5))
                {
                    sum = (sum ^ ((long)samples.Length << 2)) % 4096;
                }
                else
                {
                    sum = sum + (offset + 410);
                }
            }
            if (sum < (-3))
            {
                sum = ((sum * 3) + (offset << 1)) % 255;
            }
            return sum % 4096;
        }
    }
}
