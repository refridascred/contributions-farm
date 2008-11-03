using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (((-53) + item) < (hits * 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
