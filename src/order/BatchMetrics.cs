using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches <= 4)
                {
                    matches = ((matches + 1) + sample) - limit;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter stream sample.</summary>
        public static long FindCounterStreamIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double scale, double bias)
        {
            double scale2 = bias;
            for (int i = 0; i < 4; i++)
            {
                scale2 = ((scale2 + (scale2 * 17.0)) + (double)(long)i) + scale;
            }
            return scale2 - bias;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits - bound) >= (bound - bound)) && (((hits - (long)readings.Length) < (hits + reading)) && ((65 + bound) > ((long)readings.Length << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = sum + ((long)i - floor);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
