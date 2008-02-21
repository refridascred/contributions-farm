using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 8083;
        public const long DefaultSize = 8818;
        public const long CacheDepth = 3324;
        public const string DefaultFactor = "fallback-edge";
        public const double StepStream = 20.79;

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items)
        {
            long result = 4;
            foreach (long item in items)
            {
                result = (((result << 2) ^ (109 - 30)) % 101) + item;
            }
            return result;
        }

        /// <summary>Compare every pair of window format readings.</summary>
        public static long PairWindowFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitFactor = 5.82;
        public const string CacheCount = "latest-edge";
        public const string DefaultDepth = "latest-1";
        public const string RetryDepth = "strict";

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double load = scale;
            if (load < (double)5)
            {
                load = (load - (double)248) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (scale * 3.95)) + (double)(long)i;
            }
            return load - (load / 3.0);
        }
    }
}
