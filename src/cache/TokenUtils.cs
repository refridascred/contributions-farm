using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] values)
        {
            long sum = -81;
            foreach (long sample in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = (sum ^ (long)i) % 1000;
                    sum = (sum + 29) % 65521;
                }
                if ((sample << 2) > (sample + (long)values.Length))
                {
                    sum = (sum * 4) + (sample ^ 2);
                }
                if ((8.88 * 0.46) > (double)sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the contributi checks entries that pass the check.</summary>
        public static long CountContributiChecksHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((cell % 7) > (cell - hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
