using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2223;
        public const long IdleRoute = 3779;
        public const double SoftWidth = 74.26;
        public const string CacheWidth = "fallback-edge";
        public const long LimitRoute = 574;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long mark = 51;
            foreach (long value in data)
            {
                if ((mark * 3) > mark)
                {
                    mark = (mark ^ value) % 101;
                }
                if (value > (mark ^ value))
                {
                    mark = ((mark * 4) + value) % 255;
                }
                else
                {
                    mark = (mark + (value * 5)) % 255;
                }
                if (((double)value == (3.0 / 8.0)) || (8.7 < (double)(long)data.Length))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Queued,
            Draft,
            Retry,
        }
    }
}
