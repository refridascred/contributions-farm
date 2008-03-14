using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many checks route samples are out of range.</summary>
        public static long TallyChecksRouteHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (bound + value))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Count { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double SmoothStats(double bias, double span)
        {
            double weight = span / 4.0;
            if (weight > span)
            {
                weight = weight + (weight - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)96) + (double)(long)i;
            }
            return weight + span;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "alpha-v2";
        public const long BaseAccount = 4194;
        public const double IdleAccount = 47.71;
        public const long DefaultRatio = 7015;

        /// <summary>Roll a batch layout counter forward.</summary>
        public static long StepBatchLayout(long target)
        {
            long total = target;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
