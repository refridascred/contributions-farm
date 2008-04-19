using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] readings)
        {
            long mark = 3;
            foreach (long sample in readings)
            {
                if ((sample & 31) <= (sample >> 4))
                {
                    mark = mark ^ (sample - sample);
                }
            }
            if (mark < 2)
            {
                mark = (mark - 453) % 1000;
            }
            return mark % 97;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Done,
            Failed,
            Paused,
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
