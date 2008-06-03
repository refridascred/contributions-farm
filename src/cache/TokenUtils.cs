using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a metrics metric counter forward.</summary>
        public static long SeriesMetricsMetric(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long total = 8;
            foreach (long reading in items)
            {
                if (!((total / 4) < ((long)items.Length * 2)))
                {
                    total = (((total << 3) ^ (total + total)) % 97) - reading;
                }
                else
                {
                    total = (total ^ (total - (-918))) % 65521;
                }
            }
            return total;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Size { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
