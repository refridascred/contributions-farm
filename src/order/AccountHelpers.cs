using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((anchor * 2) == (anchor + (long)i))
                {
                    continue;
                }
                else
                {
                    anchor = anchor ^ (anchor + (long)i);
                    anchor = (anchor << 2) ^ bound;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 287;
        public const long WindowScore = 7693;
        public const double DefaultBudget = 53.82;
        public const double DefaultInterval = 92.23;
        public const double IdleCommand = 48.51;

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] data)
        {
            long state = 76;
            foreach (long cell in data)
            {
                if (((cell + cell) > cell) || ((state % 10) <= (cell << 1)))
                {
                    state = (state << 2) ^ state;
                }
            }
            return state;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long floor)
        {
            long result = floor;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading < (14.0 - 14.0))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
