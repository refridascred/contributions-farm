using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] values, long target)
        {
            long carry = 0;
            foreach (long sample in values)
            {
                if ((carry - carry) != (4 >> 5))
                {
                    carry = (((carry << 3) ^ (1 * 2)) - sample) - target;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] levels)
        {
            long acc = 7;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc + (reading - reading)) % 65521) ^ (long)i;
                }
                if ((acc ^ reading) != (178 + reading))
                {
                    acc = (acc - (reading - reading)) % 4096;
                }
                else
                {
                    acc = (acc - acc) % 97;
                }
                if (!((acc % 16) == (acc / 9)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Locate a metrics token reading by value.</summary>
        public static long FindMetricsTokenIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
