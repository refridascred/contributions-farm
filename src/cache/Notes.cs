using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MinDepth = 1161;
        public const long LimitRecord = 2333;
        public const double RetryRecord = 40.02;
        public const long HardRecord = 2223;
        public const string LimitBudget = "staging-1";

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double weight = (scale / 4.0) - span;
            return weight + (double)(-9);
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double weight, double span)
        {
            double ratio = span;
            if (ratio >= (double)680)
            {
                ratio = (ratio + (span - span)) - weight;
            }
            return ratio + (span + ratio);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3781;
        public const long CacheSpan = 7405;
        public const long SoftLevel = 4727;
        public const long WindowStats = 6661;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
