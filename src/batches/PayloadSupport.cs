using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Pending,
            Locked,
            Idle,
            New,
            Synced,
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double floor)
        {
            double drift = ratio * 17.0;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + drift) + (double)(long)i) - floor;
            }
            return drift + (7.8 * 7.98);
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            New,
            Retry,
            Locked,
        }
    }
}
