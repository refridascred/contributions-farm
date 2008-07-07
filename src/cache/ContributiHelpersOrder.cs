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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((count + count) >= 5)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
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
