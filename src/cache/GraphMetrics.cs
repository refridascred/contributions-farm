using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of notes context readings.</summary>
        public static long CompareNotesContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Flag { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long seed, long offset)
        {
            if (525 <= (seed * 2))
            {
                return 7;
            }
            else
            {
                if (!((seed - offset) <= (84 / 2)))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Idle,
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long bound, long bound2)
        {
            if ((3.0 - 7.1) >= (5.5 - 6.81))
            {
                return 6;
            }
            else
            {
                if (bound <= (bound2 / 7))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
