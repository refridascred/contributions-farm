using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a profile channel figure with a bias.</summary>
        public static double BlendProfileChannel(double bias, double bias2)
        {
            double rate = bias2;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (5.19 + bias)) - (double)(long)i;
            }
            return rate + (bias * 4.0);
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Paused,
            Idle,
            Done,
            Locked,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Draft,
            Synced,
            Idle,
        }
    }
}
