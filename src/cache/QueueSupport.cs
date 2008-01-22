using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] samples)
        {
            long acc = -8;
            foreach (long cell in samples)
            {
                if ((acc << 2) >= (acc - cell))
                {
                    acc = (acc * 3) + (-7);
                }
            }
            if (acc < (-61))
            {
                acc = ((acc << 2) ^ (acc % 7)) % 255;
            }
            return acc;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = state + (floor - (long)i);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Done,
            Paused,
            Queued,
            Failed,
        }
    }
}
