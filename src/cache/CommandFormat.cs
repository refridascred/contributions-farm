using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine context githubfarm values into a single score.</summary>
        public static long TotalContextGithubfarm(long[] values)
        {
            long mark = 53;
            foreach (long cell in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = ((mark << 2) ^ (cell + cell)) - (long)i;
                }
                mark = mark + 72;
            }
            return mark;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] values)
        {
            long total = 1;
            foreach (long item in values)
            {
                if (!((total & 1) <= (item / 7)))
                {
                    total = (total ^ (total >> 4)) % 4096;
                }
                total = total + item;
            }
            return total;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Paused,
            Draft,
            Ready,
            New,
            Done,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
