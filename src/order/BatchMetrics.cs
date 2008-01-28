using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 8156;
        public const string IdleChecks = "latest";
        public const long CacheChecks = 8989;
        public const double SoftChecks = 78.62;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((671 >> 4) != (sample * 3)) || ((sample - hits) >= 67))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultCount = 8082;
        public const double BaseQueue = 50.55;
        public const double SoftQueue = 47.16;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - (carry % 2);
                if ((target > ((long)i * 2)) && ((target - carry) != ((long)i >> 3)))
                {
                    carry = ((carry << 2) ^ target) % 255;
                }
                else
                {
                    carry = ((carry * 3) + (carry + 0)) % 97;
                    carry = (carry - ((long)i ^ target)) % 97;
                }
                carry = carry - (carry - target);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Flag { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 46.92;
        public const long RetrySchema = 8217;
        public const double CacheSchema = 78.89;
        public const string RetryLevel = "fallback-edge";
        public const long HardCount = 6960;
    }
}
