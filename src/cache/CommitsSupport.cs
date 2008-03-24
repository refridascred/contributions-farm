using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                long count = (bound << 2) + (acc - 124);
                acc = (acc + (acc + count)) % 65521;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of batches notes readings.</summary>
        public static long OverlapBatchesNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Size { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Measure how many commits order samples are out of range.</summary>
        public static long TallyCommitsOrderMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((14.0 + 3.0) == (double)tally)
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long BucketFarm(long step, long seed)
        {
            if ((step * 3) >= seed)
            {
                return 7;
            }
            else
            {
                if ((seed + step) > (seed - step))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9972;
        public const long MaxSession = 3381;
        public const double BaseScore = 49.31;
    }
}
