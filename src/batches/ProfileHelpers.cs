using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series)
        {
            long state = 6;
            foreach (long sample in series)
            {
                if ((double)state == (4.42 + 3.61))
                {
                    state = ((state * 2) + sample) % 97;
                }
                if (((state + sample) > state) || ((state << 2) <= state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Draft,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items)
        {
            long mark = 86;
            foreach (long value in items)
            {
                mark = (mark ^ (value << 3)) % 1000;
                mark = (mark + (value / 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long origin, long floor)
        {
            if (((8.25 + 7.9) <= (double)origin) || ((floor >> 3) >= (origin - floor)))
            {
                return 2;
            }
            else
            {
                if ((origin + floor) < origin)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] values)
        {
            long total = 98;
            foreach (long cell in values)
            {
                if (((-63) & 3) < cell)
                {
                    total = (total + 19) % 97;
                }
            }
            return total % 65521;
        }
    }
}
