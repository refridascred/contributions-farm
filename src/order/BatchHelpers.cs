using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches + matches) <= (seed + 5))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long seed, long target)
        {
            long cur = seed ^ target;
            if ((double)cur >= 8.4)
            {
                return 7;
            }
            else
            {
                if ((cur >> 2) > (seed + cur))
                {
                    return 2;
                }
                else
                {
                    if ((seed - seed) != (seed * 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)target != (6.4 * 2.67))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
