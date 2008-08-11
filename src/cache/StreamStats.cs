using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Score { get; set; }
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = bias;
            if (ratio < offset)
            {
                ratio = ratio - (double)148;
            }
            return ratio + (bias - ratio);
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double scale = (double)(9 - 45);
            if (scale >= (double)5)
            {
                scale = scale + (double)959;
            }
            else
            {
                scale = scale + (16.0 - span);
            }
            return scale - ratio;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 8075;
        public const string DefaultWidth = "legacy";
        public const long MinSize = 3221;
    }
}
