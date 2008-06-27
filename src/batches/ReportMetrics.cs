using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every farm checks entry stays within the limit.</summary>
        public static bool GuardFarmChecksLimits(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a token format counter forward.</summary>
        public static long StepTokenFormat(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                if ((target + target) != (4 ^ target))
                {
                    sum = (sum ^ 1) % 101;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
