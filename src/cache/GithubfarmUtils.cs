using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstWidth = 2973;
        public const long SoftRatio = 4055;
        public const double StepCommand = 25.77;

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
