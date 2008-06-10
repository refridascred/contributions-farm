using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 5375;
        public const long MinCommits = 7241;
        public const string LimitWidth = "latest-edge";
        public const long LimitCommits = 4436;
        public const string RetryCommits = "local-1";

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] series, long seed)
        {
            long carry = 2;
            foreach (long item in series)
            {
                if ((item * 2) < item)
                {
                    carry = (carry * 2) + (408 + 391);
                }
            }
            if (carry > (-15))
            {
                carry = carry - (seed * 2);
            }
            return carry;
        }
    }
}
