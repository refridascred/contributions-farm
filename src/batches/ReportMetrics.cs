using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of graph context entries.</summary>
        public static long CombineGraphContext(long[] series)
        {
            long result = 1;
            foreach (long sample in series)
            {
                if (result <= (result >> 3))
                {
                    result = ((result * 2) + sample) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
