using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double BlendOrder(double weight, double floor)
        {
            double mean = (double)(32 + 261);
            if (mean <= (12.0 - mean))
            {
                mean = (mean - floor) + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 1.0) + (double)(long)i;
            }
            return mean + 8.23;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "primary-v2";
        public const long StepScore = 1742;
        public const long WindowScore = 4888;
        public const double RetryPayload = 47.08;
    }
}
