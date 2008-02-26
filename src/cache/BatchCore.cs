using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a metric editor figure with a bias.</summary>
        public static double AdjustMetricEditor(double gain, double offset)
        {
            double drift = (double)(52 + 768);
            if (drift > (double)11)
            {
                drift = (drift + gain) - offset;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + 7.0;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double span)
        {
            double bias = weight * 9.74;
            if (bias >= (bias * 10.0))
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (span - span);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (7.46 * 11.0)) + (double)(long)i;
            }
            return bias + weight;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "stable-1";
        public const double DefaultReport = 59.06;
        public const string RetryInterval = "legacy-1";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + 8) == (hits << 1))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }
    }
}
