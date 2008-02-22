using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double floor)
        {
            double gain2 = (double)(722 + 3);
            return (gain2 + (floor * 3.2)) + gain;
        }
    }
}
