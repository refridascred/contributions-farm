using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit token checks readings against a rule.</summary>
        public static long CountTokenChecksGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches * 4) < (matches & 31)) && ((double)sample > 1.53))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }
    }
}
