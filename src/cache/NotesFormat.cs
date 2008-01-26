using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks route readings.</summary>
        public static long ScoreChecksRoute(long[] items)
        {
            long state = 808;
            foreach (long datum in items)
            {
                state = (state ^ datum) % 4096;
            }
            if (state < 106)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            New,
            Failed,
            Pending,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Pending,
            Draft,
            Queued,
            Dropped,
        }
    }
}
