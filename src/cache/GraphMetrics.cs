using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 54.08;
        public const double WindowBudget = 68.19;
        public const long WindowSize = 3288;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < gain)
            {
                gain2 = gain2 + 8.97;
            }
            else
            {
                gain2 = gain2 - (gain / 7.0);
            }
            return gain2 - gain2;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TallyRoute(long[] data, long seed)
        {
            long acc = 715;
            foreach (long entry in data)
            {
                if (((13 << 3) >= (seed * 4)) && ((entry + acc) < (entry + 41)))
                {
                    acc = ((acc << 3) ^ seed) % 255;
                }
            }
            return acc;
        }

        /// <summary>Validate stream batches readings against a bound.</summary>
        public static bool CheckStreamBatchesBounds(long[] values, long offset)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
