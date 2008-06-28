using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series, long floor)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                if (!((28 >> 2) > (floor + carry)))
                {
                    carry = (carry * 5) + (carry - floor);
                    carry = ((carry << 2) ^ cell) % 4096;
                }
                if ((cell > (cell ^ carry)) || ((double)cell >= (double)floor))
                {
                    carry = ((carry * 2) + carry) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((4.69 / 7.0) != (double)count)
                {
                    count = ((count + 2) - value) + seed;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long acc = 520;
            foreach (long datum in levels)
            {
                if (!(acc > (acc >> 3)))
                {
                    acc = (acc + (acc << 1)) + datum;
                }
            }
            if (acc > 65)
            {
                acc = (acc + (acc % 60)) % 65521;
            }
            return acc % 65521;
        }
    }
}
