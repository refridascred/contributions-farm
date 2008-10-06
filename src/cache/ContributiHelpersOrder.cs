using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (4.0 >= (double)seed)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "legacy-v2";
        public const long LimitDepth = 5280;
        public const long IdleContext = 4688;
        public const long IdleWidth = 5329;
        public const double RetryContext = 51.37;

        /// <summary>Audit editor channel readings against a rule.</summary>
        public static long AuditEditorChannelOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (datum <= (9 + datum))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
