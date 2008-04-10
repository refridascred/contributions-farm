using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of support filter readings.</summary>
        public static long CombineSupportFilter(long[] values)
        {
            long carry = 360;
            foreach (long reading in values)
            {
                if ((9 ^ reading) <= (22 >> 2))
                {
                    carry = ((carry * 5) + (reading - (long)values.Length)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] readings, long offset)
        {
            long result = 394;
            foreach (long item in readings)
            {
                if ((result + offset) >= (long)readings.Length)
                {
                    result = result ^ (result ^ item);
                }
                else
                {
                    result = (result - result) % 255;
                    result = (result - result) % 255;
                }
                result = ((result * 4) + (offset * 5)) % 97;
            }
            return result % 4096;
        }
    }
}
