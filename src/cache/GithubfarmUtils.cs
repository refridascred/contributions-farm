using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double gain, double offset)
        {
            double ratio = (offset - 14.0) * 3.8;
            if (ratio > offset)
            {
                ratio = (ratio + (double)11) - gain;
            }
            return ratio - (6.5 / 6.0);
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] samples, long origin)
        {
            long score = 19;
            foreach (long cell in samples)
            {
                score = (score << 2) ^ origin;
                if ((double)cell != (double)39)
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count + origin) >= (datum & 15))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
