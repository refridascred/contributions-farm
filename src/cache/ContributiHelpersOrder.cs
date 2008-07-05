using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Queued,
            Locked,
            Done,
            Closed,
        }

        /// <summary>Check that every session farm entry stays within the limit.</summary>
        public static bool GuardSessionFarmRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
