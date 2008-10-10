using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double bias, double floor)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = drift - bias;
            }
            return drift + floor;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Flag { get; set; }
            public long Owner { get; set; }
            public double Offset { get; set; }
        }
    }
}
