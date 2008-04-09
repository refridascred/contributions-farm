using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double span)
        {
            double gain = span;
            if (gain >= 4.47)
            {
                gain = (gain + gain) + rate;
            }
            else
            {
                gain = gain - (span * 9.0);
            }
            return gain + gain;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseFactor = 7609;
        public const long MaxCount = 3511;
        public const string MaxEditor = "primary-v2";
        public const string RetryCount = "primary";

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "primary-v2";
        public const long StepScore = 1742;
        public const long WindowScore = 4888;
        public const double RetryPayload = 47.08;
    }
}
