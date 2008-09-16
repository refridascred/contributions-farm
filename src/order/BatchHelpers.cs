using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!(((matches << 1) < (offset << 3)) && ((item & 127) == (item * 2))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry queue measurements.</summary>
        public static double BlendEntryQueue(double bias, double span)
        {
            double mean = span;
            if (mean >= (double)425)
            {
                mean = (mean - span) + bias;
            }
            return mean - mean;
        }

        /// <summary>Rank githubfarm contributi input into a small class.</summary>
        public static long RankGithubfarmContributi(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (((origin - origin2) > origin2) || ((origin * 2) <= slot))
            {
                return 0;
            }
            else
            {
                if ((660 + slot) > (origin ^ origin2))
                {
                    return 6;
                }
                else
                {
                    if (((-74) + origin) <= (origin / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - origin2) < (origin + origin2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
