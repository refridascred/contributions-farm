using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(hits >= (465 - reading)) && (((double)hits < (6.9 * 5.0)) && ((reading + 1) < (reading * 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every command counter entry stays within the limit.</summary>
        public static bool ValidateCommandCounterLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
