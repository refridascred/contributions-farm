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

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
