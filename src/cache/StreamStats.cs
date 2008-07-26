using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] samples, long target)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BatchMetric = 82.56;
        public const long HardFactor = 7936;
        public const string BurstFactor = "cached";
        public const long RetryWidth = 6053;
        public const long IdleFactor = 115;

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 4351;
        public const string MinRatio = "cached-1";
        public const double RetrySchema = 40.29;
    }
}
