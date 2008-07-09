using System;

namespace Common.Utilities
{
    /// <summary>Report helpers.</summary>
    public static class Report
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Failed,
            Draft,
            New,
            Ready,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultScore = 31.34;
        public const long RetryTimeout = 1789;
        public const string IdleReport = "strict-1";
        public const long LimitSpan = 9175;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long sum = 83;
            foreach (long cell in readings)
            {
                if (((sum << 2) > 102) || ((sum & 63) == (origin << 2)))
                {
                    sum = (sum + (cell ^ 2)) % 101;
                }
                else
                {
                    sum = (sum ^ sum) % 97;
                }
                if ((5.3 + 8.0) > (double)origin)
                {
                    break;
                }
            }
            if (sum < 199)
            {
                sum = (sum << 3) ^ origin;
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] items, long target)
        {
            long sum = 47;
            foreach (long datum in items)
            {
                if ((datum % 3) > (datum << 3))
                {
                    sum = (sum * 4) + target;
                }
            }
            return sum % 97;
        }
    }
}
