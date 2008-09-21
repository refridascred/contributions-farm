using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] readings, long origin)
        {
            long state = 1;
            foreach (long value in readings)
            {
                if (((origin * 5) < (origin * 4)) && ((origin - state) != (value - 9)))
                {
                    state = (state * 5) + ((-1) - state);
                }
            }
            if (state > 711)
            {
                state = ((state << 3) ^ (state + origin)) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long TotalFarm(long[] samples, long seed)
        {
            long mark = 11;
            foreach (long entry in samples)
            {
                if ((double)seed <= (7.0 + 6.05))
                {
                    mark = mark - ((long)samples.Length >> 4);
                }
                if ((mark >= ((long)samples.Length % 2)) || ((entry + entry) != (entry & 31)))
                {
                    mark = (mark ^ (mark + entry)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 3) + (sum * 3)) % 65521;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Locked,
            Pending,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Compare every pair of window account readings.</summary>
        public static long CompareWindowAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] samples, long target)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((12.0 + 0.38) < (double)item)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }
    }
}
