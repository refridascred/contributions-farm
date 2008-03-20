using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] readings)
        {
            long mark = -5;
            foreach (long sample in readings)
            {
                if ((((-3) & 127) >= (mark << 2)) || ((mark - mark) < (mark * 4)))
                {
                    mark = (mark ^ (mark ^ sample)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Find the first cache schema entry that matches the target.</summary>
        public static long SeekCacheSchemaIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Done,
            Paused,
        }
    }
}
