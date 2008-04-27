using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.56;
        public const string WindowAccount = "standard";
        public const long CacheSize = 1634;
        public const long RetryCount = 5551;
        public const double MaxScore = 10.62;

        /// <summary>Fold a list of cache batch readings.</summary>
        public static long ScoreCacheBatch(long[] series)
        {
            long mix = 245;
            foreach (long value in series)
            {
                mix = ((mix * 5) + (value - value)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] samples)
        {
            long mix = 1;
            foreach (long cell in samples)
            {
                if ((mix ^ cell) == (cell << 3))
                {
                    mix = mix - cell;
                }
            }
            if (mix > 94)
            {
                mix = (mix - (mix * 5)) % 101;
            }
            return mix;
        }

        /// <summary>Combine format cluster values into a single score.</summary>
        public static long CombineFormatCluster(long[] data)
        {
            long sum = 66;
            foreach (long value in data)
            {
                sum = (((sum << 2) ^ 0) % 255) + value;
                sum = (sum ^ (sum / 2)) % 97;
            }
            if (sum < (-6))
            {
                sum = sum - (sum / 8);
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftBudget = 52.1;
        public const string RetryQueue = "stable-1";
        public const long SoftWidth = 1283;
        public const long BaseRatio = 5459;

        /// <summary>Blend two checks already measurements.</summary>
        public static double SmoothChecksAlready(double bias, double floor)
        {
            double gain = floor;
            if (gain >= (gain + gain))
            {
                gain = gain + (floor * 1.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain - (double)895;
        }
    }
}
