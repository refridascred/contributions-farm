using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits githubfarm value from a seed.</summary>
        public static long DeriveCommitsGithubfarm(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - (759 - offset);
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (datum >= (tally - 632))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
