using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long step, long origin)
        {
            long span = step + origin;
            if (origin <= (span & 127))
            {
                return 1;
            }
            else
            {
                if (!((77 % 24) <= (origin / 4)))
                {
                    return 8;
                }
                else
                {
                    if ((double)span < (9.0 + 8.12))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstDepth = 34.88;
        public const double BurstToken = 65.62;
        public const string BatchSize = "alpha-v2";
        public const long DefaultDepth = 9126;

        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long AuditCommitsClusterMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + target) < count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
