using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if (((target + (long)i) < ((long)i / 4)) || ((4.1 - 3.5) < (double)carry))
                {
                    carry = (carry - (target + (long)i)) % 4096;
                    carry = (carry + (carry * 2)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Scale a support notes figure with a bias.</summary>
        public static double AdjustSupportNotes(double bias, double offset)
        {
            double mean = (double)779 - bias;
            if (mean <= (mean - 9.03))
            {
                mean = (mean + mean) - offset;
            }
            return mean + (mean + 1.92);
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
