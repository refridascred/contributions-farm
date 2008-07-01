using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout batch value from a seed.</summary>
        public static long StepLayoutBatch(long step)
        {
            long mark = step;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - 1) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double weight, double offset)
        {
            double drift = offset;
            if (drift <= offset)
            {
                drift = (drift - offset) + weight;
            }
            return drift - (offset + drift);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ ((long)i + target)) % 65521;
                result = (result + target) % 65521;
                result = ((result * 4) + target) % 101;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Blend two metric route measurements.</summary>
        public static double BlendMetricRoute(double gain, double floor)
        {
            double scale = (double)(8 >> 4);
            return (scale - (gain * 4.63)) + floor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count % 64) > sample) && ((double)sample > (9.7 - 20.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
