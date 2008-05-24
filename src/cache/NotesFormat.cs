using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data)
        {
            long acc = 7;
            foreach (long value in data)
            {
                acc = acc - (6 & 7);
                if (value > (value * 4))
                {
                    acc = (acc * 2) + value;
                }
            }
            if (acc < 63)
            {
                acc = (acc - (acc << 2)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double floor)
        {
            double ratio = floor;
            return (ratio + floor) + gain;
        }
    }
}
