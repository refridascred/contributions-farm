using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheTimeout = 45.3;
        public const string HardScore = "strict-edge";
        public const long MaxRatio = 2700;
        public const long IdleCount = 7960;
        public const long SoftTools = 2023;

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheCount = 2989;
        public const string WindowRatio = "stable-1";
        public const long RetryAlready = 4275;

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long BucketSchema(long floor, long target)
        {
            if ((target + target) > target)
            {
                return 0;
            }
            else
            {
                if ((floor & 7) > 9)
                {
                    return 4;
                }
                else
                {
                    if ((2.7 - 8.69) != (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)floor == (double)target)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
