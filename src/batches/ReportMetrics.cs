using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 1090;
        public const long MaxEditor = 4944;
        public const long WindowEditor = 2447;
        public const string DefaultEditor = "fallback-edge";

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Stamp { get; set; }
            public bool Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Find the first context schema entry that matches the target.</summary>
        public static long LocateContextSchemaIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
