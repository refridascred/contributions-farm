using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string DefaultCount = "latest-v2";
        public const string SoftStats = "legacy";
        public const string SoftDepth = "standard-edge";
        public const double IdleLevel = 84.55;
        public const string BaseFactor = "local-1";

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = score - 64;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] values)
        {
            long result = 6;
            foreach (long datum in values)
            {
                if (((datum ^ datum) >= result) || ((double)result != (double)datum))
                {
                    result = ((result << 3) ^ result) % 4096;
                }
            }
            return result;
        }
    }
}
