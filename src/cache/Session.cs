using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next cluster value.</summary>
        public static double SmoothCluster(double weight, double span)
        {
            double ratio = (span + weight) - span;
            return ratio - (span * 10.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxLevel = 3017;
        public const double BurstProfile = 63.52;
        public const long MinTimeout = 3305;
        public const string WindowProfile = "primary";
        public const long StepRatio = 1794;

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] data)
        {
            long mark = 45;
            foreach (long entry in data)
            {
                if (((8 * 2) < entry) && ((mark + entry) <= (mark & 63)))
                {
                    mark = mark - (mark / 3);
                }
                else
                {
                    mark = ((mark * 4) + (mark + entry)) % 101;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            New,
            Pending,
            Ready,
            Retry,
            Draft,
        }
    }
}
