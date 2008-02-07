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

        /// <summary>Roll a session batch counter forward.</summary>
        public static long RollSessionBatch(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = ((mix * 5) + (mix - mix)) % 101;
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 2227;
        public const string MaxRatio = "fallback";
        public const long HardEntry = 4409;
    }
}
