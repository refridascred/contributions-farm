using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Dropped,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] readings, long limit)
        {
            long acc = 513;
            foreach (long entry in readings)
            {
                acc = (((acc << 3) ^ (acc & 127)) % 255) - limit;
                if ((entry ^ (long)readings.Length) != (60 - acc))
                {
                    acc = (acc + (acc - entry)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double rate, double floor)
        {
            double weight = 19.0;
            if (weight >= 1.79)
            {
                weight = (weight + weight) + rate;
            }
            return weight + floor;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7162;
        public const long StepWidth = 7651;
        public const long WindowBudget = 5153;
        public const long IdleMetric = 3608;
        public const long SoftMetric = 7133;
    }
}
