using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a tools already reading by value.</summary>
        public static long LookupToolsAlreadyIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if ((step << 1) < ((long)i << 3))
                {
                    mark = (mark << 2) ^ ((long)i ^ step);
                    mark = mark - (mark % 3);
                }
                else
                {
                    mark = ((mark << 3) ^ (49 + mark)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long SeekSessionIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7860;
        public const long LimitBatch = 4310;
        public const double HardBatch = 91.13;
        public const long LimitFactor = 9702;
    }
}
