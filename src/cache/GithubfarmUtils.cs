using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Size { get; set; }
            public string Owner { get; set; } = "";
            public long Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first report graph entry that matches the target.</summary>
        public static long SeekReportGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long offset, long bound)
        {
            if ((double)offset >= (19.0 - 6.1))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (8.2 - 6.36))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
