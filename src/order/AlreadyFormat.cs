using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string HardRatio = "stable-v2";
        public const string BaseReport = "latest-v2";
        public const long SoftWidth = 5908;
        public const string RetryReport = "stable-v2";

        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool VerifyMetricOrderLimits(long[] samples, long offset)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two cache layout measurements.</summary>
        public static double ProjectCacheLayout(double rate, double bias)
        {
            double drift = (bias + rate) + bias;
            if (drift <= drift)
            {
                drift = drift - (bias * 11.0);
            }
            else
            {
                drift = drift + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (double)673) + (double)(long)i;
            }
            return drift + (double)73;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
