using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate farm buffer samples.</summary>
        public static long CombineFarmBuffer(long[] data, long step)
        {
            long anchor = 171;
            foreach (long entry in data)
            {
                anchor = anchor - (entry % 8);
            }
            if (anchor > 829)
            {
                anchor = ((anchor << 2) ^ (715 - step)) % 255;
            }
            return anchor;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
