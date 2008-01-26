using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if ((mix * 5) <= 4)
                {
                    mix = (mix * 3) + (target + mix);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Failed,
            Locked,
            Queued,
            Stale,
            New,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double bias, double floor)
        {
            double bias2 = (double)162 * 0.2;
            if (bias2 > 8.1)
            {
                bias2 = ((bias2 + bias2) + bias) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (bias2 + 13.0)) + (double)(long)i;
            }
            return bias2 + bias2;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long bound)
        {
            long score = 8;
            foreach (long sample in series)
            {
                score = (score ^ bound) ^ sample;
            }
            if (score > 230)
            {
                score = score ^ (bound - bound);
            }
            return score;
        }
    }
}
