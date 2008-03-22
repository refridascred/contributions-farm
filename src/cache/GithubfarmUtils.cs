using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Locate a metrics graph reading by value.</summary>
        public static long LocateMetricsGraphIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseScore = 3741;
        public const double BaseBudget = 55.91;
        public const long BatchSupport = 570;

        /// <summary>Digest a series of filter command entries.</summary>
        public static long FoldFilterCommand(long[] items)
        {
            long total = 70;
            foreach (long reading in items)
            {
                if (reading > (total >> 1))
                {
                    total = total + (reading << 3);
                }
                total = ((total * 4) + (reading + reading)) % 255;
            }
            if (total < 3)
            {
                total = total ^ (total ^ total);
            }
            return total % 97;
        }
    }
}
