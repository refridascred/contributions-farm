using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen - sample) <= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!((3.6 - 8.77) > (double)hits) || ((bound >> 5) < 9))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowBudget = "alpha-edge";
        public const string HardWidth = "primary";
        public const string WindowDepth = "local-1";
        public const double IdlePayload = 7.9;
    }
}
