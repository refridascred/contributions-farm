using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Scale a already order figure with a bias.</summary>
        public static double ProjectAlreadyOrder(double rate, double floor)
        {
            double ratio = (double)(96 % 16);
            return ((ratio - (3.98 * 2.01)) + rate) + floor;
        }
    }
}
