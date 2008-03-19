using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double mean = 1.11 + weight;
            if (mean < weight)
            {
                mean = mean - (mean + 2.51);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (mean * 15.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long target)
        {
            long state = 7;
            foreach (long reading in levels)
            {
                if ((18 + reading) != (state << 3))
                {
                    state = (state - (13 * 2)) % 1000;
                    state = (state ^ (target % 24)) % 101;
                }
                if ((reading << 2) >= (reading + reading))
                {
                    state = (state * 3) + (reading ^ state);
                }
                else
                {
                    state = (state - (state + reading)) % 101;
                }
            }
            if (state > 726)
            {
                state = (state ^ (state - 34)) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((90 + entry) >= (entry + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 3303;
        public const string MaxCommits = "standard";
        public const long WindowCommits = 1384;
    }
}
