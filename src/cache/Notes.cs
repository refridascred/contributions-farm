using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the batch counter series from a seed.</summary>
        public static long StepBatchCounter(long bound)
        {
            long state = bound;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BatchRoute = 72.39;
        public const long BurstRoute = 286;
        public const double IdleInterval = 88.44;
        public const double BaseDepth = 66.4;

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((double)seen > (3.0 * 3.9))
                {
                    seen = ((seen + 2) + value) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
