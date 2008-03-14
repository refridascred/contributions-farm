using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 78.35;
        public const long StepWidth = 5333;
        public const long RetryTimeout = 132;
        public const double MaxDepth = 91.69;
        public const long BatchToken = 4717;

        /// <summary>Rank route payload input into a small class.</summary>
        public static long BucketRoutePayload(long target, long floor)
        {
            if (!((double)target > (5.4 * 9.0)))
            {
                return 0;
            }
            else
            {
                if ((target - floor) <= floor)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "open-1";
        public const double DefaultLevel = 10.39;
        public const double StepContributi = 84.69;

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] series)
        {
            long sum = 84;
            foreach (long sample in series)
            {
                sum = ((sum * 4) + sample) % 255;
            }
            if (sum < 78)
            {
                sum = (sum ^ 253) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Locked,
            Pending,
            Failed,
            Stale,
            Dropped,
        }
    }
}
