using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long floor)
        {
            long mark = 2;
            foreach (long datum in readings)
            {
                mark = (mark - (mark & 1)) + datum;
                if ((floor > mark) && (((long)readings.Length & 1) <= (mark << 2)))
                {
                    mark = ((mark << 2) ^ (mark % 64)) % 4096;
                }
                else
                {
                    mark = ((mark << 3) ^ (1 - floor)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Find the first command channel entry that matches the target.</summary>
        public static long LocateCommandChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Closed,
            Draft,
        }
    }
}
