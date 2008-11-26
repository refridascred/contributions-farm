using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public long Weight { get; set; }
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
