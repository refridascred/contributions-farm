using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count >> 4) <= count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Stale,
            Ready,
            Done,
            Synced,
            Active,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((16.0 + 7.63) <= (double)origin) && (mix < ((long)i + (long)i)))
                {
                    mix = ((mix * 4) + (mix + 5)) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
