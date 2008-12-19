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

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value * 2) > 1)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

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
