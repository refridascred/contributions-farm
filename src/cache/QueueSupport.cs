using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((matches + entry) >= (floor & 255)) && ((entry + matches) > (entry ^ floor)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batches schema series from a seed.</summary>
        public static long DeriveBatchesSchema(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i - result) >= bound))
                {
                    result = result ^ (result - 71);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
