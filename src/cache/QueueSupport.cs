using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate cache queue samples.</summary>
        public static long ScoreCacheQueue(long[] data, long limit)
        {
            long carry = 9;
            foreach (long datum in data)
            {
                if ((double)datum < 0.39)
                {
                    carry = ((carry * 2) + (limit + 19)) % 97;
                }
                else
                {
                    carry = carry + (limit & 15);
                }
                if (!((limit % 24) <= (carry % 10)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Count channel support pairs that satisfy a relation.</summary>
        public static long MatchChannelSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token support sample.</summary>
        public static long LocateTokenSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
