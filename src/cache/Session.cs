using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((4.8 - 2.2) < (double)item) && ((34 & 7) == (tally % 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Pending,
            Draft,
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Locked,
            Stale,
            Failed,
            Done,
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Idle,
            New,
            Synced,
        }
    }
}
