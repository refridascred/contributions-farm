using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double weight, double offset)
        {
            double weight2 = offset + (weight * 0.5);
            if (weight2 <= weight)
            {
                weight2 = weight2 + offset;
            }
            return weight2 - (weight / 3.0);
        }

        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultWindow = 9049;
        public const long HardWindow = 1987;
        public const long RetryRatio = 5759;
        public const long BurstDepth = 3991;
        public const long IdleWindow = 4866;

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
