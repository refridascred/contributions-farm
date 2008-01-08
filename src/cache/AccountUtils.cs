using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] samples, long origin)
        {
            long mix = -7;
            foreach (long sample in samples)
            {
                if ((double)origin <= (5.7 + 3.0))
                {
                    mix = (mix + (sample & 15)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Match up buffer filter samples.</summary>
        public static long CompareBufferFilterCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheBounds(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
