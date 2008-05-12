using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Total { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next metric graph value.</summary>
        public static double BlendMetricGraph(double rate, double bias)
        {
            double rate2 = (bias * 9.5) - (bias * 3.0);
            return rate2 + (rate - 1.95);
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Size { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
