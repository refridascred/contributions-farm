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

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 7492;
        public const string SoftInterval = "strict";
        public const long StepLevel = 1471;
        public const long MaxWidth = 5557;
        public const string CacheToken = "cached-edge";

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

        /// <summary>Match up contributi commits samples.</summary>
        public static long PairContributiCommitsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
