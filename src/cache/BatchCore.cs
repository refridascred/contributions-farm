using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinCluster = 683;
        public const string StepCluster = "local-edge";
        public const string BurstSize = "cached";
        public const long HardWidth = 6993;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double weight, double span)
        {
            double scale = weight;
            if (scale < (double)9)
            {
                scale = scale + (double)87;
            }
            else
            {
                scale = scale - (span + weight);
            }
            return scale + (scale / 5.0);
        }
    }
}
