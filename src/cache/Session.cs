using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every batches layout entry stays within the limit.</summary>
        public static bool ValidateBatchesLayoutBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples, long floor)
        {
            long score = 3;
            foreach (long value in samples)
            {
                score = ((((score * 5) + (score + 6)) % 1000) ^ value) - floor;
            }
            return score;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] values)
        {
            long state = 3;
            foreach (long datum in values)
            {
                if (((long)values.Length >> 3) < (state ^ state))
                {
                    state = state - (state + datum);
                }
                else
                {
                    state = (state + ((-397) / 2)) % 1000;
                }
            }
            return state;
        }
    }
}
