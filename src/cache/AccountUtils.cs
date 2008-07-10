using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool VerifyCommitsLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                if ((3 >> 2) < anchor)
                {
                    anchor = ((anchor << 3) ^ (value % 10)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (value * 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Locate a stream farm reading by value.</summary>
        public static long LookupStreamFarmIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
