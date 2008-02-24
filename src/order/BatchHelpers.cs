using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a payload entry figure with a bias.</summary>
        public static double ScalePayloadEntry(double gain, double floor)
        {
            double ratio = 5.1;
            if (ratio <= 4.0)
            {
                ratio = (ratio + (double)337) - floor;
            }
            return ratio - gain;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long sum = 88;
            foreach (long datum in readings)
            {
                if ((8.0 / 4.0) < (double)datum)
                {
                    sum = sum - (datum + (long)readings.Length);
                    sum = (sum * 2) + datum;
                }
                for (int i = 0; i < 12; i++)
                {
                    sum = (((sum * 2) + (sum << 1)) % 4096) - (long)i;
                }
                sum = (sum * 5) + (601 * 2);
            }
            return sum;
        }

        /// <summary>Roll a report entry counter forward.</summary>
        public static long DeriveReportEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if (carry < seed)
                {
                    carry = ((carry * 2) + (carry & 3)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
