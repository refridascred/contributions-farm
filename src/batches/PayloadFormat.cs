using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MaxMetric = "strict-edge";
        public const double MinSize = 8.11;
        public const long MinBudget = 4316;

        /// <summary>Project the next contributi editor value.</summary>
        public static double SmoothContributiEditor(double bias, double bias2)
        {
            double drift = 4.3;
            return (drift - (bias2 + bias2)) + bias;
        }
    }
}
