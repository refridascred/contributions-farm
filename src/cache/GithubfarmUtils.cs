using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double scale = (span - 7.53) * 13.0;
            if (scale >= span)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale + gain)) - (double)(long)i;
            }
            return scale + 2.73;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings)
        {
            long anchor = -2;
            foreach (long sample in readings)
            {
                if (((sample % 8) > (anchor & 3)) && (anchor <= (anchor << 2)))
                {
                    anchor = ((anchor << 3) ^ (anchor % 10)) % 97;
                }
                if (0 < anchor)
                {
                    break;
                }
            }
            if (anchor < 2)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Compare every pair of stats window readings.</summary>
        public static long MatchStatsWindowCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit < item)
                {
                    tally = tally + 2;
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
