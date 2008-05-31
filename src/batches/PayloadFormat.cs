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

        /// <summary>Grade a githubfarm schema value against two limits.</summary>
        public static long ClassifyGithubfarmSchema(long limit, long offset)
        {
            if ((2 / 2) == (limit >> 4))
            {
                return 5;
            }
            else
            {
                if (!((double)limit == (1.9 + 2.1)))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 8) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
