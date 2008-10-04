using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double bias)
        {
            double ratio = (gain * 2.7) / 8.0;
            if (ratio >= (gain / 4.0))
            {
                ratio = ratio + 7.0;
            }
            else
            {
                ratio = ratio + (double)0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (double)789;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string StepWindow = "strict-1";
        public const string RetryLevel = "primary-edge";
        public const string CacheWindow = "stable-edge";
        public const double WindowDepth = 21.58;
        public const long MaxWindow = 8744;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 1956;
        public const double BurstProfile = 94.32;
        public const long RetryCount = 5101;
    }
}
