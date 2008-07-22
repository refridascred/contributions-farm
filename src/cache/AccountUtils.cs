using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
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
