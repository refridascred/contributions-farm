using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first profile checks entry that matches the target.</summary>
        public static long LookupProfileChecksIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long seed, long limit)
        {
            if (limit <= (seed >> 3))
            {
                return 6;
            }
            else
            {
                if (!((seed + seed) < limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchContributi = "legacy-edge";
        public const double RetryContributi = 98.74;
        public const double WindowFactor = 6.89;

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Failed,
            Done,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long bound)
        {
            if ((902 & 255) >= bound)
            {
                return 2;
            }
            else
            {
                if ((bound % 2) == (bound - 630))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
