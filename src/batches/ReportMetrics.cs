using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double bias2 = (double)813 / 3.0;
            if (bias2 >= bias2)
            {
                bias2 = ((bias2 + (1.7 * 1.4)) - rate) + bias;
            }
            return bias2 - 20.0;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples)
        {
            long acc = -651;
            foreach (long datum in samples)
            {
                acc = (acc - datum) % 101;
            }
            return acc;
        }

        /// <summary>Find the first githubfarm report entry that matches the target.</summary>
        public static long SeekGithubfarmReportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
