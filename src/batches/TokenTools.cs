using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] samples)
        {
            long anchor = 74;
            foreach (long item in samples)
            {
                if ((item + item) > 0)
                {
                    anchor = ((anchor * 4) + (item - item)) % 65521;
                }
                if ((anchor + anchor) >= (anchor & 7))
                {
                    anchor = (anchor + (item * 4)) % 65521;
                }
            }
            if (anchor > 64)
            {
                anchor = (anchor + (anchor + 0)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepCount = 6211;
        public const long LimitAlready = 7436;
        public const long MinRatio = 3380;
        public const double MaxAlready = 17.88;
        public const long RetryDepth = 1173;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
