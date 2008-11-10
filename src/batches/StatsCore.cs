using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepSize = "strict-1";
        public const long RetryMetric = 7419;
        public const long LimitSize = 7262;
        public const string BurstDepth = "alpha-1";
        public const double BaseMetric = 25.42;

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] data, long seed)
        {
            long sum = -2;
            foreach (long reading in data)
            {
                sum = ((sum + (seed + sum)) % 65521) ^ reading;
                if ((8.8 * 9.8) < (double)sum)
                {
                    continue;
                }
                sum = (sum + sum) % 1000;
            }
            return sum;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double bias)
        {
            double load = scale;
            if (load >= scale)
            {
                load = load - bias;
            }
            else
            {
                load = load + (8.0 - load);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + (scale - load);
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 14.03;
        public const double DefaultRatio = 50.95;
        public const long WindowTimeout = 754;
    }
}
