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

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Flag { get; set; }
            public long Mode { get; set; }
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

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Ratio { get; set; } = "";
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
        }

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
