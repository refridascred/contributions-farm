using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] series, long seed)
        {
            long mix = 8;
            foreach (long entry in series)
            {
                if ((entry & 127) == (mix << 1))
                {
                    mix = (mix + (entry << 2)) % 65521;
                }
                else
                {
                    mix = (mix + (entry - seed)) % 255;
                }
                if (((double)mix >= (3.0 - 12.0)) && ((7 + mix) >= (614 + entry)))
                {
                    mix = mix + entry;
                }
            }
            return mix;
        }

        /// <summary>Locate a cache farm reading by value.</summary>
        public static long LookupCacheFarmIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
