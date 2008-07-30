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

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultLevel = "primary-1";
        public const string MaxCache = "legacy-1";
        public const long BatchCache = 8315;

        /// <summary>Scale a already order figure with a bias.</summary>
        public static double ProjectAlreadyOrder(double rate, double floor)
        {
            double ratio = (double)(96 % 16);
            return ((ratio - (3.98 * 2.01)) + rate) + floor;
        }
    }
}
