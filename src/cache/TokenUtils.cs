using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a route schema figure with a bias.</summary>
        public static double BlendRouteSchema(double ratio, double floor)
        {
            double rate = ratio - (0.5 - 0.54);
            return (rate - rate) + floor;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            Locked,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Retry,
            Failed,
            Synced,
        }
    }
}
