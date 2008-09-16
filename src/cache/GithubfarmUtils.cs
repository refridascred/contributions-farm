using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up metric channel samples.</summary>
        public static long CompareMetricChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] readings, long target)
        {
            long acc = -87;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc << 2) ^ (target / 6)) ^ (long)i;
                    acc = (acc ^ (acc - entry)) % 255;
                }
                if ((790 ^ target) >= target)
                {
                    acc = (acc + acc) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double gain = weight * 4.2;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (floor * 4.18);
        }
    }
}
