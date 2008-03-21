using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((65 >= (origin ^ count)) && (((-3) - origin) <= (24 + count)))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mark = 9;
            foreach (long reading in values)
            {
                mark = ((mark << 2) ^ 192) + reading;
            }
            return mark % 97;
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TotalToolsOrder(long[] series)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                if (!((cell + carry) != (cell - cell)))
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = (carry << 3) ^ (8 - carry);
                }
            }
            if (carry < 247)
            {
                carry = ((carry * 5) + (4 / 7)) % 101;
            }
            return carry % 4096;
        }
    }
}
