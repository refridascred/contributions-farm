using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double bias = (offset + 5.0) + (double)63;
            if (bias > (offset + gain))
            {
                bias = bias + (bias - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)653) + (double)(long)i;
            }
            return bias + (double)99;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchSize = 4887;
        public const long MinSpan = 7186;
        public const long IdleAlready = 8357;
        public const double CacheScore = 75.2;
        public const long CacheTimeout = 4664;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] series, long origin)
        {
            long state = 870;
            foreach (long item in series)
            {
                state = (state + (item - 79)) % 101;
                if (origin >= (state % 60))
                {
                    state = (state ^ (9 / 3)) % 97;
                }
                else
                {
                    state = state - (origin + origin);
                }
            }
            return state;
        }
    }
}
