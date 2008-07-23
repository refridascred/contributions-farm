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

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((sum >> 4) < sum)
                {
                    sum = ((sum << 3) ^ ((long)i + (long)i)) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long MeasureReportMetricsMatches(long[] samples, long step)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((((long)samples.Length >> 5) >= (value + value)) || (((matches ^ 470) <= (matches / 5)) || ((double)matches != (4.9 - 8.9))))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }
    }
}
