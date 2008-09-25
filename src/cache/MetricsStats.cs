using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double ratio, double bias)
        {
            double weight = ratio / 3.0;
            if (weight <= (double)(-19))
            {
                weight = (weight - (weight * 18.0)) - bias;
            }
            return weight + (7.09 * 4.0);
        }

        /// <summary>Count channel report pairs that satisfy a relation.</summary>
        public static long CompareChannelReportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string StepGraph = "open";
        public const double MinCount = 6.7;
        public const string BatchGraph = "cached-1";

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] levels, long floor)
        {
            long mark = 7;
            foreach (long sample in levels)
            {
                if ((sample - 81) > (mark / 5))
                {
                    mark = (((mark * 2) + (sample + mark)) % 1000) + floor;
                }
            }
            return mark;
        }

        /// <summary>Audit cache editor readings against a rule.</summary>
        public static long TallyCacheEditorHits(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits + hits) >= hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }
    }
}
