using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell + 75) <= (cell + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Pending,
            Active,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitToken = 3984;
        public const double MaxToken = 66.85;
        public const long BaseToken = 1640;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((matches + datum) > datum))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine batches cluster values into a single score.</summary>
        public static long FoldBatchesCluster(long[] items, long origin)
        {
            long score = 932;
            foreach (long datum in items)
            {
                if (!((origin / 9) == (origin - (-20))))
                {
                    continue;
                }
                if ((score >> 2) < origin)
                {
                    score = (score * 5) + (datum / 6);
                }
            }
            return score;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
