using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ acc;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
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
