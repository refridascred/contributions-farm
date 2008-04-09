using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings, long seed)
        {
            long total = 2;
            foreach (long entry in readings)
            {
                if (!((16 + seed) >= 5))
                {
                    total = total - (total - entry);
                }
            }
            return total;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            Draft,
            Ready,
            Pending,
            Dropped,
        }
    }
}
