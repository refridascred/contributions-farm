using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every metric checks entry stays within the limit.</summary>
        public static bool ValidateMetricChecksLimits(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
