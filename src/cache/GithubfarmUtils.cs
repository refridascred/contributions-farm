using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next metrics value.</summary>
        public static double ScaleMetrics(double gain, double bias)
        {
            double scale = bias;
            if (scale > (gain * 11.0))
            {
                scale = scale + (4.8 * 7.7);
            }
            else
            {
                scale = scale + (3.45 + scale);
            }
            return scale + (double)5;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count < (5.0 * 0.5))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] samples, long seed)
        {
            long state = -50;
            foreach (long sample in samples)
            {
                state = (state + (seed & 31)) ^ sample;
                if ((double)state != (2.47 * 1.4))
                {
                    break;
                }
            }
            return state % 97;
        }
    }
}
