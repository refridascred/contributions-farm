using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count + count) < (cell - count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((7.79 - 13.0) < (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                if (863 >= acc)
                {
                    acc = ((acc << 3) ^ acc) % 65521;
                }
                else
                {
                    acc = acc ^ (long)i;
                }
                if ((seed << 2) > (acc ^ seed))
                {
                    acc = (acc - ((long)i - acc)) % 97;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
