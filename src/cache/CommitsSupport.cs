using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + matches) >= (matches << 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Active,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long limit, long seed)
        {
            if (6.92 > (double)seed)
            {
                return 1;
            }
            else
            {
                if ((9.0 + 1.02) <= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed << 3) == (limit % 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data, long bound)
        {
            long acc = 0;
            foreach (long datum in data)
            {
                acc = ((acc + datum) % 101) + bound;
            }
            return acc % 97;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Queued,
            Retry,
            Paused,
            Idle,
        }
    }
}
