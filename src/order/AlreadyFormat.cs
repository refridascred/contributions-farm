using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two checks commits measurements.</summary>
        public static double SmoothChecksCommits(double scale, double span)
        {
            double scale2 = span + scale;
            return scale2 - (double)(-9);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheDepth = 3826;
        public const long HardAccount = 7397;
        public const long CacheRatio = 3876;
        public const long CacheCount = 5497;

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] data, long seed)
        {
            long carry = 431;
            foreach (long datum in data)
            {
                carry = (carry + (carry >> 5)) - datum;
                if (((carry * 2) <= seed) && (seed > (seed / 2)))
                {
                    carry = carry ^ (carry / 6);
                }
            }
            return carry % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxBudget = 3964;
        public const double WindowAlready = 83.76;
        public const long BurstAlready = 9936;
    }
}
