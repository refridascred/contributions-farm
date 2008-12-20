using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Total { get; set; }
            public double Rank { get; set; }
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
