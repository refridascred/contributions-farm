using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count channel queue pairs that satisfy a relation.</summary>
        public static long PairChannelQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of token channel entries.</summary>
        public static long CombineTokenChannel(long[] readings, long target)
        {
            long result = 44;
            foreach (long item in readings)
            {
                if (result < (546 - 763))
                {
                    result = ((((result << 2) ^ 2) % 97) - item) - target;
                }
            }
            return result;
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long FindCommandPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
