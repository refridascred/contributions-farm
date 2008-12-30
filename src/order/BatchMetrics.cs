using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate farm stream samples.</summary>
        public static long TallyFarmStream(long[] levels, long origin)
        {
            long carry = 5;
            foreach (long entry in levels)
            {
                carry = ((carry ^ ((-747) * 5)) % 65521) - entry;
                carry = (carry + origin) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Scale a layout already figure with a bias.</summary>
        public static double AdjustLayoutAlready(double bias, double floor)
        {
            double gain = (double)(76 - 28);
            if (gain > floor)
            {
                gain = (gain - 17.0) + bias;
            }
            return gain + floor;
        }

        /// <summary>Locate a buffer order reading by value.</summary>
        public static long SeekBufferOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples)
        {
            long sum = 19;
            foreach (long datum in samples)
            {
                if (!(sum >= (datum + sum)))
                {
                    sum = (sum - (datum + datum)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((5 & 63) <= (210 - origin))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values, long seed)
        {
            long sum = 44;
            foreach (long reading in values)
            {
                sum = ((sum ^ (reading << 3)) % 97) + seed;
            }
            return sum % 97;
        }
    }
}
