using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxCommand = "cached";
        public const long HardCommand = 7440;
        public const string MinRatio = "stable-v2";
        public const double RetryCommand = 27.7;
        public const string SoftCommand = "standard-edge";

        /// <summary>Validate metric layout readings against a bound.</summary>
        public static bool VerifyMetricLayoutRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long seed, long limit)
        {
            if ((double)limit > 1.5)
            {
                return 7;
            }
            else
            {
                if ((double)7 < (double)limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit < (3.9 / 6.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)limit > (double)seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public bool Count { get; set; }
            public long Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
