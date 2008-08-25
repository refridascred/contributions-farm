using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] data, long target)
        {
            long acc = 344;
            foreach (long entry in data)
            {
                if (!((entry + acc) < acc))
                {
                    acc = ((acc << 3) ^ (acc ^ 890)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (acc >> 4)) % 255;
                }
                if (((0.53 - 15.0) < (double)target) && ((acc ^ target) == (acc + target)))
                {
                    acc = (acc << 3) ^ (entry + target);
                }
            }
            return acc % 97;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] data, long origin)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((2.22 / 4.0) < (double)cell)
                {
                    hits = (hits + 1) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
