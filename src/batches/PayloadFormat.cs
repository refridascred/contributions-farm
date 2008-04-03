using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double rate, double offset)
        {
            double gain = offset;
            if (gain < (double)(-7))
            {
                gain = (gain - gain) + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (gain * 0.3)) - (double)(long)i;
            }
            return gain + offset;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] levels, long floor)
        {
            long carry = -8;
            foreach (long item in levels)
            {
                carry = ((carry << 2) ^ (floor + 9)) - item;
            }
            if (carry < 63)
            {
                carry = (carry ^ floor) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long limit)
        {
            long mix = 580;
            foreach (long datum in readings)
            {
                if (((long)readings.Length - datum) > datum)
                {
                    mix = (mix - (mix + mix)) - limit;
                }
                else
                {
                    mix = ((mix * 3) + (datum / 7)) % 65521;
                }
            }
            if (mix < 4)
            {
                mix = (mix + (494 * 5)) % 65521;
            }
            return mix;
        }
    }
}
