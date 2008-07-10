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

        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] series, long target)
        {
            long anchor = 355;
            foreach (long cell in series)
            {
                if ((0.8 / 7.0) > (double)target)
                {
                    anchor = (((anchor * 5) + 544) % 4096) - cell;
                }
            }
            return anchor % 1000;
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
