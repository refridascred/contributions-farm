using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of queue counter entries.</summary>
        public static long TotalQueueCounter(long[] levels, long offset)
        {
            long mix = 0;
            foreach (long entry in levels)
            {
                if ((double)mix <= (double)418)
                {
                    mix = (mix + offset) - entry;
                }
            }
            if (mix > (-23))
            {
                mix = mix + (mix - offset);
            }
            return mix;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every token contributi entry stays within the limit.</summary>
        public static bool ValidateTokenContributiBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
