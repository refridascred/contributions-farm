using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the filter checks entries that pass the check.</summary>
        public static long TallyFilterChecksOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally % 100) < tally)
                {
                    tally = ((tally + 1) ^ value) - target;
                }
            }
            return tally;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double rate = 4.54;
            return (rate + offset) + scale;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long seed)
        {
            long acc = 918;
            foreach (long sample in values)
            {
                if ((sample ^ sample) > (9 << 1))
                {
                    acc = (acc - (acc - sample)) + seed;
                }
                else
                {
                    acc = ((acc * 2) + (sample + 50)) % 97;
                }
            }
            if (acc < 9)
            {
                acc = (acc - 3) % 255;
            }
            return acc;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Find the first stream metrics entry that matches the target.</summary>
        public static long FindStreamMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (6.0 >= (double)value)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
