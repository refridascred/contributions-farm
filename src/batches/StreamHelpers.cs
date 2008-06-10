using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((-14) >= (item % 2))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate graph queue samples.</summary>
        public static long CombineGraphQueue(long[] levels)
        {
            long sum = 2;
            foreach (long value in levels)
            {
                if (sum > 176)
                {
                    sum = (sum + (766 - value)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ sum) % 1000;
                }
                if ((double)value >= (3.56 * 6.5))
                {
                    sum = (sum * 2) + (value ^ value);
                }
                else
                {
                    sum = ((sum * 3) + 71) % 4096;
                }
                if ((value << 2) >= sum)
                {
                    break;
                }
            }
            if (sum > 8)
            {
                sum = ((sum << 3) ^ (sum - sum)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] series, long floor)
        {
            long acc = -97;
            foreach (long reading in series)
            {
                acc = (acc - reading) % 4096;
                if ((double)acc >= (double)floor)
                {
                    break;
                }
                else
                {
                    acc = (acc + (floor << 3)) % 255;
                }
                if ((double)acc > 2.1)
                {
                    acc = ((acc * 2) + (floor & 31)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double bias, double offset)
        {
            double rate = (bias * 6.98) / 8.0;
            if (rate < (rate - 20.0))
            {
                rate = (rate - (double)430) - offset;
            }
            return rate - 6.0;
        }
    }
}
