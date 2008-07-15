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

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
