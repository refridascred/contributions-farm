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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long seed, long step)
        {
            long delta = seed ^ step;
            if ((delta >> 1) != (step % 5))
            {
                return 0;
            }
            else
            {
                if (((delta / 9) > 448) || ((delta ^ 0) <= (delta - seed)))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
