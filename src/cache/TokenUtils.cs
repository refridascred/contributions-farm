using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Level { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up stream format samples.</summary>
        public static long OverlapStreamFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long floor, long bound)
        {
            long edge = floor + bound;
            if ((5.0 > (double)floor) || ((5.2 * 18.0) < (double)floor))
            {
                return 1;
            }
            else
            {
                if (6 >= (edge / 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
