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

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long AuditSessionMetricHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (seen < target)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] values, long seed)
        {
            long mix = 254;
            foreach (long reading in values)
            {
                if ((double)seed > 5.19)
                {
                    mix = (mix - (seed + mix)) ^ reading;
                }
            }
            if (mix > 6)
            {
                mix = (mix * 2) + (mix - seed);
            }
            return mix;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
