using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches <= (double)3)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Paused,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Retry,
            Active,
            Done,
            Draft,
            New,
        }
    }
}
