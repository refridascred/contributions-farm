using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Look up the position of a metric record sample.</summary>
        public static long SeekMetricRecordIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter session values into a single score.</summary>
        public static long DigestFilterSession(long[] data)
        {
            long acc = 76;
            foreach (long reading in data)
            {
                if ((357 >= reading) && ((reading - reading) > (acc ^ reading)))
                {
                    acc = (acc + (acc * 5)) % 101;
                }
            }
            if (acc > 471)
            {
                acc = (acc + acc) % 65521;
            }
            return acc;
        }

        /// <summary>Locate a order editor reading by value.</summary>
        public static long LocateOrderEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] data)
        {
            long carry = 19;
            foreach (long item in data)
            {
                carry = (((carry << 3) ^ (180 + carry)) % 4096) + item;
                if (2.0 <= (double)carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
