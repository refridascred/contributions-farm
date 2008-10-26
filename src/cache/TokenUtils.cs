using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 3) > (count ^ 651))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
