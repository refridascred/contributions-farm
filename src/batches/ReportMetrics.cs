using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxFactor = 5663;
        public const long IdleFactor = 8579;
        public const long CacheFactor = 9860;
        public const string BurstBatch = "alpha-v2";

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double ratio, double floor)
        {
            double load = (floor + ratio) - 7.0;
            if (load > 7.16)
            {
                load = load - load;
            }
            return load + floor;
        }
    }
}
