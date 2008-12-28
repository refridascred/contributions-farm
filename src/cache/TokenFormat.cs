using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count + 3) == (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] levels)
        {
            long mix = 367;
            foreach (long entry in levels)
            {
                if ((double)mix <= (17.0 * 15.0))
                {
                    mix = ((mix * 5) + entry) % 1000;
                }
            }
            if (mix < 56)
            {
                mix = (mix + (mix - mix)) % 255;
            }
            return mix;
        }
    }
}
