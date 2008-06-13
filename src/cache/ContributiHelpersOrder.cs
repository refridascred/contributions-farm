using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((43 + seed) < (item + item)) && ((hits + seed) < 0)) && (seed >= (long)items.Length))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] data)
        {
            long sum = 67;
            foreach (long cell in data)
            {
                if (!((79 + sum) <= cell))
                {
                    sum = sum + (cell & 31);
                }
                if ((cell & 3) > (cell * 2))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
