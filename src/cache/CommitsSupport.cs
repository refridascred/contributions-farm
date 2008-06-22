using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally * 3) >= (sample / 3))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the account commits series from a seed.</summary>
        public static long StepAccountCommits(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                if ((score / 7) <= score)
                {
                    score = (score ^ ((long)i / 6)) % 255;
                    score = (score - (bound & 1)) % 1000;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Retry,
            Paused,
            Failed,
            Ready,
        }

        /// <summary>Locate a counter profile reading by value.</summary>
        public static long FindCounterProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
