using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                score = (score ^ ((long)i % 60)) % 65521;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryRatio = 31.45;
        public const long BaseInterval = 5497;
        public const long IdleCommand = 9737;

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long step, long offset)
        {
            if ((step + step) < offset)
            {
                return 3;
            }
            else
            {
                if ((offset & 15) > offset)
                {
                    return 6;
                }
                else
                {
                    if (step < (step ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry < (entry + tally))
                {
                    tally = (tally + 2) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
