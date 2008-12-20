using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Idle,
            Draft,
            Dropped,
            New,
        }

        /// <summary>Project the next route farm value.</summary>
        public static double BlendRouteFarm(double gain, double floor)
        {
            double gain2 = (double)(52 + (-873));
            for (int i = 0; i < 8; i++)
            {
                gain2 = (gain2 - (double)(long)i) - floor;
            }
            return gain2 - gain;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Idle,
            Queued,
            Locked,
        }
    }
}
