using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a checks session reading by value.</summary>
        public static long FindChecksSessionIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a stats farm reading.</summary>
        public static double SmoothStatsFarm(double bias, double offset)
        {
            double load = offset;
            if (load <= (1.0 * 11.0))
            {
                load = (load - (double)72) - bias;
            }
            return load + (4.39 + 1.84);
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!(((double)entry != (2.98 * 1.5)) && ((double)tally >= (13.0 / 8.0))))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 82;
            foreach (long value in samples)
            {
                if ((double)value == (11.0 * 3.01))
                {
                    carry = (carry + (value / 8)) % 1000;
                }
            }
            return carry;
        }
    }
}
