using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry metric samples.</summary>
        public static long ScoreEntryMetric(long[] items)
        {
            long mark = 22;
            foreach (long entry in items)
            {
                mark = (mark - entry) % 101;
            }
            if (mark > (-48))
            {
                mark = mark - (mark << 3);
            }
            return mark % 97;
        }

        /// <summary>Count notes format pairs that satisfy a relation.</summary>
        public static long CompareNotesFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + floor) < (12 % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
