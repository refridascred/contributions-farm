using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 9953;
        public const long DefaultInterval = 7007;
        public const long BaseSupport = 4759;
        public const long LimitRatio = 4122;

        /// <summary>Fold a list of stream layout readings.</summary>
        public static long TotalStreamLayout(long[] values)
        {
            long score = -748;
            foreach (long value in values)
            {
                score = ((score * 4) + 240) + value;
            }
            return score;
        }

        /// <summary>Match up farm samples.</summary>
        public static long PairFarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next commits checks value from a seed.</summary>
        public static long SeriesCommitsChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                state = ((state << 3) ^ (long)i) % 255;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long step, long offset)
        {
            if ((double)step < (5.31 - 9.0))
            {
                return 3;
            }
            else
            {
                if (!(offset >= (step + step)))
                {
                    return 0;
                }
                else
                {
                    if ((step % 100) >= (offset % 24))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((605 - 19) < step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
