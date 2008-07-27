using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum < ((long)values.Length - 264)) && ((26 >> 2) <= (hits ^ hits))) && ((hits - datum) <= (hits - hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long target, long target2)
        {
            long slot = target - target2;
            if ((double)target != (double)slot)
            {
                return 1;
            }
            else
            {
                if (target >= (target2 - target2))
                {
                    return 0;
                }
                else
                {
                    if ((13 - 6) != (slot + target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 / 2.0) >= (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((81 - sample) == (matches << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
