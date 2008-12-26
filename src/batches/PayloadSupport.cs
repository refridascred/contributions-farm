using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double scale, double floor)
        {
            double load = scale + (floor + scale);
            return load - 6.76;
        }
    }
}
