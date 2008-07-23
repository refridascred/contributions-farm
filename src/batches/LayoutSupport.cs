using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Retry,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Audit checks cache readings against a rule.</summary>
        public static long MeasureChecksCacheMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((11.0 - 3.0) < (double)count)
                {
                    count = ((count + 2) + entry) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double gain, double offset)
        {
            double weight = (double)(78 ^ 2);
            if (weight >= offset)
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight + (double)3;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (double)9) - (double)(long)i;
            }
            return weight - (gain / 6.0);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
