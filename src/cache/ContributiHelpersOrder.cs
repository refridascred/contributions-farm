using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Idle,
            Failed,
            Paused,
            New,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit cluster notes readings against a rule.</summary>
        public static long MeasureClusterNotesOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((floor >> 4) >= floor)
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }
    }
}
