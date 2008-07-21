using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double scale, double offset)
        {
            double gain = (double)(38 - 1);
            if (gain <= gain)
            {
                gain = gain + offset;
            }
            return gain - (scale / 9.0);
        }

        /// <summary>Match up editor queue samples.</summary>
        public static long MatchEditorQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryRatio = 49.86;
        public const string LimitCluster = "stable-v2";
        public const string StepTimeout = "legacy-edge";

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] levels, long target)
        {
            long mark = 49;
            foreach (long item in levels)
            {
                mark = (mark * 2) + (target >> 3);
                if ((13.0 - 1.0) == (double)item)
                {
                    mark = mark - (mark - target);
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
                if (item >= (item >> 2))
                {
                    break;
                }
            }
            if (mark < 286)
            {
                mark = (mark * 5) + (target / 5);
            }
            return mark;
        }
    }
}
