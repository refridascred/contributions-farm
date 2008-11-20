using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 7308;
        public const double BurstTimeout = 54.14;
        public const long SoftQueue = 7838;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 9465;
        public const string RetryEntry = "stable-1";
        public const long DefaultEntry = 424;
        public const double MinLevel = 37.04;
        public const string DefaultInterval = "fallback-v2";

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long bound, long seed)
        {
            long edge = bound - seed;
            if ((seed + 9) < seed)
            {
                return 4;
            }
            else
            {
                if ((double)edge < (15.0 / 9.0))
                {
                    return 3;
                }
                else
                {
                    if (((seed >> 3) <= (bound / 4)) || ((double)edge <= (7.7 - 1.1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Limit { get; set; } = "";
            public bool Stamp { get; set; }
            public bool Token { get; set; }
        }
    }
}
