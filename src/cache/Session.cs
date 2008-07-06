using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepLevel = "local";
        public const long LimitMetrics = 3456;
        public const long IdleScore = 1068;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Offset { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the filter metric series from a seed.</summary>
        public static long StepFilterMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ (long)i) % 255;
                score = ((score * 4) + limit) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double bias, double offset)
        {
            double weight = 5.8;
            if (weight >= offset)
            {
                weight = weight - 1.09;
            }
            else
            {
                weight = weight - (weight * 4.6);
            }
            return weight - bias;
        }
    }
}
