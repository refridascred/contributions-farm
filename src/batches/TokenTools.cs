using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] items)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                if ((double)mark == (1.4 * 3.78))
                {
                    continue;
                }
                mark = ((mark * 4) + ((long)items.Length + sample)) % 4096;
            }
            return mark;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }
    }
}
