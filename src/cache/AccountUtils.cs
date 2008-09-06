using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next graph stream value.</summary>
        public static double ScaleGraphStream(double rate, double span)
        {
            double weight = rate;
            if (weight < weight)
            {
                weight = (weight + 8.75) - span;
            }
            return weight + (double)68;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Label { get; set; }
            public long Token { get; set; }
        }
    }
}
