using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 6910;
        public const long CacheEditor = 9209;
        public const long RetryTimeout = 5211;
        public const string LimitWidth = "primary-edge";
        public const double MinBudget = 75.81;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Closed,
            New,
            Draft,
            Queued,
        }

        /// <summary>Derive the next checks session value from a seed.</summary>
        public static long RollChecksSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total ^ (total + (long)i);
                total = (total - 836) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long limit, long origin)
        {
            long slot = limit ^ origin;
            if ((double)slot >= 3.0)
            {
                return 1;
            }
            else
            {
                if ((627 + origin) == (origin + limit))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
