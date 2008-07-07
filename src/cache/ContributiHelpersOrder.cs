using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine support batch values into a single score.</summary>
        public static long TallySupportBatch(long[] data)
        {
            long carry = 301;
            foreach (long item in data)
            {
                carry = ((carry * 2) + (item / 5)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long acc = 127;
            foreach (long cell in readings)
            {
                if (((cell + (long)readings.Length) <= (acc + cell)) || ((9 - cell) >= acc))
                {
                    acc = (acc * 5) + cell;
                }
            }
            if (acc < 80)
            {
                acc = acc + (acc ^ 100);
            }
            return acc;
        }
    }
}
