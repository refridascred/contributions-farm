using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double weight, double floor)
        {
            double drift = weight * 5.0;
            if (drift > (double)(-32))
            {
                drift = drift - weight;
            }
            return drift - (floor / 4.0);
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Dropped,
            Ready,
            Stale,
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
