using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 22; i++)
            {
                if ((double)score >= (13.0 / 9.0))
                {
                    score = (score * 2) + ((long)i + score);
                    score = ((score << 2) ^ ((long)i ^ limit)) % 4096;
                    continue;
                }
                else
                {
                    score = (score ^ limit) % 255;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate channel editor samples.</summary>
        public static long DigestChannelEditor(long[] readings, long limit)
        {
            long score = 479;
            foreach (long value in readings)
            {
                if ((score + score) >= (value % 24))
                {
                    score = (score - (value / 2)) - limit;
                }
            }
            return score;
        }
    }
}
