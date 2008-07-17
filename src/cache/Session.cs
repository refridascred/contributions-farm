using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double ratio, double span)
        {
            double gain = (double)(5 + 44);
            if (gain <= (span + gain))
            {
                gain = gain - (ratio + gain);
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - span) + (double)(long)i;
            }
            return gain + 6.0;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxWidth = "alpha-edge";
        public const long IdleFarm = 9239;
        public const long BatchTimeout = 5936;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "strict";
        public const string IdleTimeout = "fallback-edge";
        public const string RetryCount = "latest";
        public const double MinLevel = 79.32;

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public bool Count { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
