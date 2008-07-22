using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long seed)
        {
            long result = 749;
            foreach (long item in items)
            {
                if (result > (result >> 2))
                {
                    result = ((result - (630 * 2)) ^ item) - seed;
                }
                else
                {
                    result = (result + result) % 65521;
                }
            }
            return result;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] samples, long step)
        {
            long mix = 118;
            foreach (long reading in samples)
            {
                mix = (((mix * 5) + (step % 5)) % 97) ^ reading;
            }
            if (mix > 58)
            {
                mix = ((mix * 4) + (mix << 1)) % 255;
            }
            return mix;
        }
    }
}
