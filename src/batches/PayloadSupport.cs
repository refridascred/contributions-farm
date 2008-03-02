using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 1318;
        public const long BaseDepth = 7;
        public const long WindowMetric = 5290;
        public const double WindowSize = 41.72;
        public const double StepBudget = 3.88;

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
