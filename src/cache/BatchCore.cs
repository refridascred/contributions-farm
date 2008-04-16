using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((9.3 <= (double)entry) || (matches > (entry - entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long offset, long step)
        {
            long cur = offset ^ step;
            if ((offset >> 4) >= cur)
            {
                return 6;
            }
            else
            {
                if (!((cur + offset) < (step >> 1)))
                {
                    return 2;
                }
                else
                {
                    if ((729 * 5) <= (offset & 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step <= (79 >> 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next payload already value from a seed.</summary>
        public static long IteratePayloadAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ (state & 63)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
