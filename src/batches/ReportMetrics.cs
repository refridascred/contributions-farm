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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 2) + (origin << 2)) % 1000;
                anchor = ((anchor << 3) ^ anchor) % 65521;
                if ((double)anchor < 5.05)
                {
                    anchor = (anchor * 3) + origin;
                }
                else
                {
                    anchor = (anchor ^ (2 * 3)) % 4096;
                    anchor = anchor + anchor;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
