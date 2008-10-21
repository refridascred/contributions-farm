using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long seed)
        {
            long score = seed;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Limit { get; set; }
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((1.83 - 17.0) < (17.0 + 14.0))
                {
                    seen = ((seen + 3) + sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!(5 <= (matches - value)) && ((double)value <= (double)1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count the token contributi entries that pass the check.</summary>
        public static long MeasureTokenContributiMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((step ^ count) == (step >> 5))
                {
                    count = (count + 1) - entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
