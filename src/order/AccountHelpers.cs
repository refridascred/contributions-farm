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

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Level { get; set; }
            public string Weight { get; set; } = "";
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

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(carry < (carry + carry)))
                {
                    carry = (carry + (long)i) % 97;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((step + seen) == (69 + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
