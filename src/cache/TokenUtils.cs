using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next profile counter value from a seed.</summary>
        public static long DeriveProfileCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 8; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] values)
        {
            long score = 9;
            foreach (long sample in values)
            {
                score = (score - (sample % 16)) % 4096;
                if ((8.79 - 5.0) > (double)score)
                {
                    score = ((score << 2) ^ (sample - sample)) % 4096;
                }
            }
            if (score < 38)
            {
                score = score ^ (score * 3);
            }
            return score;
        }
    }
}
