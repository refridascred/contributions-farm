using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long bound, long target)
        {
            if (bound <= (bound * 5))
            {
                return 7;
            }
            else
            {
                if ((bound + bound) > (-879))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8630;
        public const long LimitLayout = 8318;
        public const long MaxLayout = 4021;
        public const long CacheWidth = 6709;

        /// <summary>Digest a series of commits entries.</summary>
        public static long TallyCommits(long[] items)
        {
            long mark = 898;
            foreach (long sample in items)
            {
                mark = (mark * 2) + (35 + sample);
            }
            return mark % 4096;
        }
    }
}
