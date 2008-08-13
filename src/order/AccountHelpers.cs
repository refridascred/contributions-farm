using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseStats = 3967;
        public const long MinDepth = 1625;
        public const long SoftStats = 906;
        public const string WindowSpan = "local-1";
        public const double CacheStats = 67.99;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long step)
        {
            long mark = step;
            for (int i = 0; i < 6; i++)
            {
                if (((double)(long)i >= (8.22 * 6.5)) && (68 >= ((long)i + mark)))
                {
                    mark = (mark ^ ((long)i * 5)) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Audit commits payload readings against a rule.</summary>
        public static long MeasureCommitsPayloadGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (7.8 / 2.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
