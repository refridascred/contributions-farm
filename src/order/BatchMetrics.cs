using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 37.69;
        public const double MaxContributi = 19.1;
        public const long SoftBudget = 3054;

        /// <summary>Scale a order format figure with a bias.</summary>
        public static double AdjustOrderFormat(double gain, double span)
        {
            double bias = gain / 4.0;
            if (bias > 5.7)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (span + span)) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + datum) != (offset + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi batches readings.</summary>
        public static long WeighContributiBatches(long[] readings, long seed)
        {
            long acc = 798;
            foreach (long value in readings)
            {
                if ((acc * 3) < (value - 63))
                {
                    acc = (acc - (acc - 6)) % 1000;
                }
            }
            if (acc < 29)
            {
                acc = (acc - (seed - 384)) % 97;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 261;
        public const double LimitFactor = 51.25;
        public const double DefaultTimeout = 54.71;

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
