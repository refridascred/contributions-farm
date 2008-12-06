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

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long score = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score ^ (score << 1)) % 1000) - (long)i2;
                }
                if ((limit * 5) > (score << 3))
                {
                    score = (score - ((long)i << 1)) % 1000;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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
