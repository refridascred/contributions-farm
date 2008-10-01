using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 4386;
        public const long MinRoute = 5238;
        public const long BaseRoute = 8879;
        public const string IdleFactor = "strict-edge";
        public const double BaseRatio = 70.66;

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
