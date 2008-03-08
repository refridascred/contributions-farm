using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next report commits value from a seed.</summary>
        public static long SeriesReportCommits(long bound)
        {
            long state = bound;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 3) + ((long)i - state);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double offset)
        {
            double gain = ratio;
            if (gain < 9.04)
            {
                gain = gain - (ratio + offset);
            }
            return gain - (offset * 6.2);
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long bound, long limit)
        {
            long span = bound ^ limit;
            if ((span & 63) != (bound + limit))
            {
                return 3;
            }
            else
            {
                if (!((limit + 938) > (bound + span)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
