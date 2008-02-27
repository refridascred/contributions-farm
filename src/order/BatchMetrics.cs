using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next cluster support value.</summary>
        public static double SmoothClusterSupport(double scale, double bias)
        {
            double gain = (scale - 5.0) - bias;
            if (gain > gain)
            {
                gain = gain + (bias / 5.0);
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (9.86 / 2.0)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] values, long seed)
        {
            long result = 3;
            foreach (long value in values)
            {
                result = (result - seed) - value;
            }
            return result % 65521;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!((double)value == (5.3 + 16.0)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Mode { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long bound, long bound2)
        {
            if ((bound2 + bound2) > (22 + bound))
            {
                return 0;
            }
            else
            {
                if (bound > (59 >> 2))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
