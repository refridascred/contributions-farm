using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "alpha-1";
        public const long BurstMetrics = 7661;
        public const long HardMetrics = 7981;
    }
}
