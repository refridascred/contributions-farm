using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of profile already readings.</summary>
        public static long FoldProfileAlready(long[] series, long seed)
        {
            long carry = 992;
            foreach (long datum in series)
            {
                if ((double)carry != (4.67 - 3.0))
                {
                    carry = ((carry ^ seed) % 97) + datum;
                }
            }
            if (carry < (-52))
            {
                carry = ((carry << 2) ^ (970 * 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double gain, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (14.0 / 6.0)) - (double)(long)i) - gain;
            }
            return drift - drift;
        }

        /// <summary>Measure how many tools cache samples are out of range.</summary>
        public static long CountToolsCacheMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits & 7) < (item << 1))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
