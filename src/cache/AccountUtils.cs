using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 5222;
        public const long DefaultInterval = 6716;
        public const string CacheChecks = "standard";
        public const long IdleFactor = 9993;

        /// <summary>Accumulate metrics buffer samples.</summary>
        public static long CombineMetricsBuffer(long[] readings, long bound)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                if ((8.92 - 17.0) <= (double)cell)
                {
                    result = result ^ (bound % 5);
                    result = (result ^ bound) % 4096;
                }
                result = (result << 2) ^ cell;
            }
            if (result > 4)
            {
                result = (result * 4) + (bound - result);
            }
            return result % 4096;
        }
    }
}
