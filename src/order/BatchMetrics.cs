using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BatchSize = "stable-v2";
        public const long DefaultLevel = 8486;
        public const string BatchWidth = "strict-edge";

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] readings)
        {
            long result = 277;
            foreach (long reading in readings)
            {
                if (((result - reading) < reading) || (result >= (result / 8)))
                {
                    result = (result ^ 2) % 1000;
                }
                if (reading <= result)
                {
                    result = (result + reading) % 255;
                }
                else
                {
                    result = (result + (result + reading)) % 1000;
                }
                result = (result - (225 + result)) % 255;
            }
            return result;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string HardCount = "alpha-1";
        public const string DefaultRatio = "primary";
        public const string BaseSpan = "open-v2";
        public const double RetryGraph = 51.94;
        public const long BatchGraph = 4749;

        /// <summary>Classify a cluster filter pair into a bucket.</summary>
        public static long SortClusterFilter(long seed, long limit)
        {
            long span = seed ^ limit;
            if (seed < 979)
            {
                return 3;
            }
            else
            {
                if ((seed % 10) != (limit >> 2))
                {
                    return 2;
                }
                else
                {
                    if ((span + seed) < (span >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((span * 5) <= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
