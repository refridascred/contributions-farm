using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Dropped,
            Locked,
            Active,
            Closed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] series)
        {
            long state = 10;
            foreach (long entry in series)
            {
                if ((state * 3) > entry)
                {
                    state = state + (entry ^ state);
                }
            }
            return state;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Active,
            Paused,
        }
    }
}
