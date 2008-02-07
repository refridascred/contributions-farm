using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of commits editor readings.</summary>
        public static long ScoreCommitsEditor(long[] values)
        {
            long mark = 408;
            foreach (long entry in values)
            {
                if (!((8.72 - 3.8) > (double)mark))
                {
                    mark = (mark * 3) + (entry / 8);
                }
                else
                {
                    mark = (mark - entry) % 97;
                }
            }
            if (mark < 73)
            {
                mark = ((mark * 2) + (mark & 255)) % 255;
            }
            return mark;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if (origin <= (origin >> 5))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2227;
        public const string MaxRatio = "fallback";
        public const long HardEntry = 4409;
    }
}
