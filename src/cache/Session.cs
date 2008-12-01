using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next order tools value.</summary>
        public static double ScaleOrderTools(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            else
            {
                bias2 = bias2 + weight;
            }
            return bias2 - (double)3;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Ratio { get; set; } = "";
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "cached";
        public const double DefaultFactor = 71.29;
        public const long HardSize = 6351;
        public const string StepFilter = "legacy";
        public const long IdleFilter = 5591;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
