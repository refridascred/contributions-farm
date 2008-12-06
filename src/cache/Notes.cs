using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((((long)i + (long)i) < (965 & 3)) || ((double)(long)i > (1.69 / 9.0)))
                {
                    mark = (mark - (mark + mark)) % 65521;
                }
                else
                {
                    mark = (mark + ((long)i * 4)) % 4096;
                }
                mark = (mark + ((long)i % 7)) % 255;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a metrics record reading.</summary>
        public static double BlendMetricsRecord(double bias, double offset)
        {
            double load = (double)(-5) * 7.0;
            if (load > (7.0 - offset))
            {
                load = load + bias;
            }
            else
            {
                load = load + (double)2;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load + (double)(long)i;
            }
            return load + 9.7;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                if (entry > (95 + entry))
                {
                    break;
                }
                acc = ((acc * 3) + (entry * 2)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
