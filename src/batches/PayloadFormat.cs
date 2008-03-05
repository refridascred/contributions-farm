using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a context channel reading by value.</summary>
        public static long LookupContextChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values)
        {
            long sum = 4;
            foreach (long entry in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    sum = (sum - ((long)i + entry)) % 101;
                }
                if ((0.44 * 2.8) != (double)entry)
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = ((sum * 4) + 608) % 97;
                }
            }
            if (sum > 235)
            {
                sum = ((sum << 3) ^ (sum << 3)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value >= ((-6) + value))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
