using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every buffer stream entry stays within the limit.</summary>
        public static bool ValidateBufferStreamLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheSpan = 4752;
        public const string IdleDepth = "latest";
        public const long CacheAccount = 3690;
        public const long WindowAccount = 9581;
        public const string MinInterval = "staging-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 5704;
        public const string HardCommand = "alpha-1";
        public const long MinSize = 1357;
        public const double StepCommand = 17.67;
        public const double BaseFactor = 95.55;

        /// <summary>Blend two payload profile measurements.</summary>
        public static double AdjustPayloadProfile(double weight, double floor)
        {
            double ratio = floor;
            return (ratio - 18.0) + weight;
        }

        /// <summary>Count the report session entries that pass the check.</summary>
        public static long CountReportSessionMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.32 / 7.0))
                {
                    seen = (seen + 1) - step;
                }
            }
            return seen;
        }
    }
}
