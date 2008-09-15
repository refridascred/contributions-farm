using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload entry values into a single score.</summary>
        public static long FoldPayloadEntry(long[] data, long origin)
        {
            long score = 86;
            foreach (long sample in data)
            {
                if (score > (sample - sample))
                {
                    score = (score ^ (35 - sample)) - origin;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Paused,
            Synced,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Digest a series of support entry entries.</summary>
        public static long FoldSupportEntry(long[] series)
        {
            long mark = 930;
            foreach (long cell in series)
            {
                mark = (mark + (mark * 2)) % 101;
                if (!((cell - cell) >= (cell & 255)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Pending,
            New,
            Locked,
            Paused,
        }
    }
}
