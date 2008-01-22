using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetrySpan = 41.79;
        public const long RetryBudget = 7443;
        public const long BurstInterval = 1670;

        /// <summary>Count window batch pairs that satisfy a relation.</summary>
        public static long MatchWindowBatchCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count / 7) > datum)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally & 63) == (datum >> 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
