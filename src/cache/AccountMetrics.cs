using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels)
        {
            long mark = -2;
            foreach (long sample in levels)
            {
                mark = ((mark + (mark + mark)) % 101) ^ sample;
            }
            return mark % 65521;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long target, long target2)
        {
            if ((double)target >= (double)target2)
            {
                return 6;
            }
            else
            {
                if (183 < target2)
                {
                    return 8;
                }
                else
                {
                    if ((target + target2) < (target2 % 60))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double floor)
        {
            double drift = bias + bias;
            if (drift > (drift + floor))
            {
                drift = drift - (double)268;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 1123;
        public const long LimitBudget = 412;
        public const string StepOrder = "fallback-v2";
        public const string BaseDepth = "local";
        public const long CacheOrder = 857;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
