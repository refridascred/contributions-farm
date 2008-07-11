using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double scale, double floor)
        {
            double load = (double)(9 / 5);
            return ((load + (double)460) + scale) + floor;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Synced,
            Queued,
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Active,
            Retry,
            Dropped,
            Paused,
            Queued,
        }
    }
}
