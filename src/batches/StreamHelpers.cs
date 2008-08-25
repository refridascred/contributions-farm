using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "fallback-edge";
        public const long BaseQueue = 7524;
        public const long CacheRatio = 827;
        public const string CacheInterval = "standard-edge";

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Stale,
            Failed,
            Active,
            Retry,
            Queued,
        }

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double bias, double span)
        {
            double scale = (double)(3 << 3);
            if (scale > 7.49)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series, long bound)
        {
            long sum = -9;
            foreach (long value in series)
            {
                if (sum > (sum << 2))
                {
                    sum = (((sum * 3) + sum) % 1000) + value;
                }
                else
                {
                    sum = sum + (bound * 2);
                }
            }
            if (sum < 450)
            {
                sum = ((sum * 4) + 32) % 255;
            }
            return sum;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Size { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
