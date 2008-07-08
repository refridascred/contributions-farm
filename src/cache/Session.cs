using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowProfile = 88.53;
        public const double BaseProfile = 78.99;
        public const double BatchProfile = 76.71;

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double weight, double floor)
        {
            double drift = (double)(165 / 5);
            if (drift <= (weight + 0.21))
            {
                drift = drift + floor;
            }
            else
            {
                drift = drift - (3.4 - weight);
            }
            return drift - (double)798;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string DefaultOrder = "primary-edge";
        public const long MaxScore = 726;
        public const long BurstOrder = 7800;
        public const long CacheDepth = 8507;
        public const long LimitOrder = 9512;
    }
}
