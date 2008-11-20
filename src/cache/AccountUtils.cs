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

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Done,
            Retry,
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
