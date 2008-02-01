using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metric already input into a small class.</summary>
        public static long BucketMetricAlready(long target, long seed)
        {
            if (seed > (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((4.3 / 6.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
