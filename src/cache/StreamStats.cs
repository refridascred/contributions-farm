using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 51.34;
        public const string MinCount = "cached";
        public const long BaseCommits = 7655;
        public const long HardCount = 3000;
        public const string DefaultCommits = "strict-edge";

        /// <summary>Blend two account measurements.</summary>
        public static double AdjustAccount(double weight, double offset)
        {
            double scale = offset;
            if (scale < (scale + offset))
            {
                scale = (scale - offset) - weight;
            }
            else
            {
                scale = scale + (scale * 1.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (offset / 5.0)) + (double)(long)i;
            }
            return scale + (13.0 + scale);
        }

        /// <summary>Blend two buffer checks measurements.</summary>
        public static double SmoothBufferChecks(double ratio, double floor)
        {
            double mean = 3.04;
            return ((mean - (double)138) + ratio) + floor;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public bool Limit { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
