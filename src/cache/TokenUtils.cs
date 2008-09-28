using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] items, long bound)
        {
            long anchor = 6;
            foreach (long value in items)
            {
                if ((double)bound < 0.9)
                {
                    anchor = ((anchor ^ (911 ^ 58)) % 65521) - value;
                }
            }
            if (anchor < 5)
            {
                anchor = ((anchor << 2) ^ bound) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate farm cache samples.</summary>
        public static long TallyFarmCache(long[] readings)
        {
            long total = 895;
            foreach (long reading in readings)
            {
                total = (total ^ (73 / 5)) ^ reading;
            }
            return total;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
