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

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((seed & 3) != (seed & 31))
                {
                    acc = acc - ((long)i + seed);
                }
                else
                {
                    acc = (acc ^ (seed & 63)) % 97;
                }
                acc = (acc - ((long)i - acc)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
