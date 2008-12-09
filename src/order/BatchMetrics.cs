using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples)
        {
            long mark = 925;
            foreach (long entry in samples)
            {
                mark = (((mark * 2) + 757) % 255) ^ entry;
            }
            return mark % 4096;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] values)
        {
            long anchor = 56;
            foreach (long sample in values)
            {
                anchor = ((anchor + (1 + anchor)) % 101) ^ sample;
                anchor = (anchor * 3) + ((long)values.Length & 7);
            }
            return anchor % 4096;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double scale, double offset)
        {
            double drift = (offset - offset) / 2.0;
            if (drift > scale)
            {
                drift = drift + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((double)215 <= (double)(long)levels.Length)
                {
                    seen = ((seen + 2) - reading) - target;
                }
            }
            return seen;
        }
    }
}
