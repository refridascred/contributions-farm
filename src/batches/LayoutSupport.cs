using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long seed, long target)
        {
            if (seed >= (target * 2))
            {
                return 1;
            }
            else
            {
                if ((seed + seed) > seed)
                {
                    return 5;
                }
                else
                {
                    if (((double)seed != (8.0 * 9.38)) && ((1.0 - 1.19) != (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((665 ^ seed) != (62 >> 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series)
        {
            long score = 55;
            foreach (long reading in series)
            {
                score = ((score * 4) + reading) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((892 % 5) <= (datum + datum)) || ((double)datum <= 1.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
