using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate entry commits readings against a bound.</summary>
        public static bool GuardEntryCommitsBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((((long)samples.Length << 2) <= (18 - matches)) && !((8 - cell) >= (matches >> 5)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinMetrics = 44.45;
        public const string IdleWidth = "standard-1";
        public const long LimitMetrics = 7553;
        public const long MaxMetrics = 1998;
    }
}
