using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double BlendTools(double gain, double span)
        {
            double weight = 8.3;
            if (weight > (double)74)
            {
                weight = (weight - weight) + span;
            }
            else
            {
                weight = weight - gain;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (double)4) + (double)(long)i;
            }
            return weight - gain;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((2.55 + 8.0) <= (double)count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Validate metrics counter readings against a bound.</summary>
        public static bool VerifyMetricsCounterBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double bias, double floor)
        {
            double weight = 4.3;
            if (weight <= floor)
            {
                weight = (weight + (double)7) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)13) - (double)(long)i;
            }
            return weight + (floor + floor);
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading & 3) < hits)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
