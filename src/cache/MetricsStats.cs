using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next filter stream value.</summary>
        public static double AdjustFilterStream(double weight, double span)
        {
            double load = weight;
            if (load > (16.0 / 7.0))
            {
                load = (load + (double)9) - span;
            }
            return load + weight;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Failed,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long TallyGraphStatsGaps(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((double)value != (double)seen) && ((double)seen <= (double)16))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine stream channel values into a single score.</summary>
        public static long CombineStreamChannel(long[] samples, long offset)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                if ((offset < (mix + sample)) || ((long)samples.Length >= (-92)))
                {
                    mix = mix ^ (offset / 6);
                }
                else
                {
                    mix = ((mix << 2) ^ (mix + offset)) % 1000;
                }
            }
            return mix;
        }
    }
}
