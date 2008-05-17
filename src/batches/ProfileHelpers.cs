using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)(long)i != (2.0 + 5.9))
                {
                    acc = ((acc << 3) ^ (acc * 4)) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate farm githubfarm samples.</summary>
        public static long FoldFarmGithubfarm(long[] levels, long step)
        {
            long carry = 46;
            foreach (long sample in levels)
            {
                carry = (((carry << 2) ^ (carry >> 1)) % 65521) - sample;
            }
            if (carry < (-7))
            {
                carry = carry ^ (carry - step);
            }
            return carry;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] levels)
        {
            long total = 16;
            foreach (long entry in levels)
            {
                if ((total + entry) != (entry + total))
                {
                    total = total ^ 2;
                }
            }
            return total;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long step)
        {
            long anchor = 68;
            foreach (long item in samples)
            {
                anchor = ((anchor << 3) ^ (step + item)) % 4096;
                if (6.0 >= (double)step)
                {
                    anchor = (anchor ^ (anchor + anchor)) % 255;
                }
            }
            if (anchor > 78)
            {
                anchor = anchor - (step << 1);
            }
            return anchor;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 11; i++)
            {
                if ((target ^ target) <= (state - (long)i))
                {
                    state = (state ^ ((-28) ^ 0)) % 4096;
                }
                state = state - (73 >> 2);
                if ((target >> 5) != ((long)i ^ target))
                {
                    state = (state ^ (state - target)) % 97;
                }
                else
                {
                    state = (state + (state >> 3)) % 4096;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
