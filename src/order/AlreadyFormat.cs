using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] data, long target)
        {
            long state = -686;
            foreach (long cell in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state ^ (target << 3)) % 65521) + (long)i;
                    state = (state - (state ^ target)) % 255;
                }
                state = state ^ (cell - target);
            }
            if (state > 51)
            {
                state = ((state << 3) ^ (state - target)) % 255;
            }
            return state;
        }

        /// <summary>Classify a farm stream pair into a bucket.</summary>
        public static long GradeFarmStream(long limit, long floor)
        {
            long offset = limit + floor;
            if (!((3.84 + 2.6) == (double)offset))
            {
                return 6;
            }
            else
            {
                if (((10.0 - 2.2) >= (double)limit) || (limit < (limit * 4)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank commits support input into a small class.</summary>
        public static long RankCommitsSupport(long bound, long offset)
        {
            if (((double)offset != (11.0 - 18.0)) && ((bound - offset) < offset))
            {
                return 4;
            }
            else
            {
                if ((bound + offset) >= (bound / 3))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
