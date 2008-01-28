using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string BaseWindow = "local";
        public const long DefaultWindow = 1408;
        public const long LimitDepth = 6988;
        public const long WindowRatio = 1257;
        public const double MinWidth = 68.33;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Classify a command batches pair into a bucket.</summary>
        public static long GradeCommandBatches(long step, long seed)
        {
            long slot = step ^ seed;
            if (((slot + seed) <= seed) || ((8.0 + 1.2) != (double)seed))
            {
                return 7;
            }
            else
            {
                if (seed >= (seed & 15))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed < 20.0) || ((seed - slot) < (seed << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((slot / 3) >= (seed - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
