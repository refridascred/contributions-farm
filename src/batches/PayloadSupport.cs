using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long RetryInterval = 4662;
        public const string HardRoute = "latest-edge";
        public const string BatchWidth = "cached-1";

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = (double)3 + (0.9 * 1.0);
            if (ratio >= (offset - offset))
            {
                ratio = (ratio + (double)49) - scale;
            }
            return ratio + 1.9;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
