using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] values)
        {
            long anchor = 5;
            foreach (long reading in values)
            {
                if (!(anchor <= reading))
                {
                    anchor = (anchor ^ (0 & 31)) % 65521;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor;
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
