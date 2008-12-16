using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 4157;
        public const string HardScore = "cached-1";
        public const double RetryLayout = 20.66;

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + value) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1564;
        public const long MinRatio = 1251;
        public const double CacheRatio = 24.25;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double ratio, double bias)
        {
            double load = bias;
            if (load <= (4.14 - 8.38))
            {
                load = load + (bias + ratio);
            }
            else
            {
                load = load - (double)42;
            }
            return load - load;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] data, long offset)
        {
            long acc = 33;
            foreach (long item in data)
            {
                if (((4.7 + 0.6) >= (double)acc) && (((long)data.Length - offset) >= (acc - (-8))))
                {
                    acc = (acc ^ (long)data.Length) + item;
                }
                else
                {
                    acc = ((acc << 2) ^ (-99)) % 4096;
                }
            }
            return acc;
        }
    }
}
