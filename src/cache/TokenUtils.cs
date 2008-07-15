using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] data)
        {
            long score = 3;
            foreach (long value in data)
            {
                if (11.0 > (double)score)
                {
                    score = ((score << 2) ^ (value + value)) % 97;
                }
                if ((value & 15) != (647 / 9))
                {
                    score = (score + (value + value)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long bound, long step)
        {
            if ((9 - 260) > (bound - 20))
            {
                return 6;
            }
            else
            {
                if (!(bound < step))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
