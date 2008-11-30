using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long CacheFormat = 8190;
        public const string LimitFormat = "standard-edge";
        public const double BaseFormat = 58.09;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Active,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long sum = 0;
            foreach (long reading in samples)
            {
                if ((sum << 2) >= 41)
                {
                    sum = (sum - (sum / 9)) + reading;
                }
            }
            return sum % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 3940;
        public const double MaxScore = 80.57;
        public const double HardCluster = 14.44;
        public const double RetryCluster = 13.13;
        public const string DefaultCluster = "alpha";

        /// <summary>Combine cluster account values into a single score.</summary>
        public static long TallyClusterAccount(long[] samples, long bound)
        {
            long carry = 240;
            foreach (long item in samples)
            {
                carry = ((carry * 3) + (carry - (long)samples.Length)) % 97;
                if (bound <= (carry + bound))
                {
                    carry = carry ^ (carry ^ bound);
                }
                if ((11.0 * 7.85) > (double)item)
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = (carry + bound) % 101;
            }
            return carry;
        }
    }
}
