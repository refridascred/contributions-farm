using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long step)
        {
            long result = 78;
            foreach (long item in data)
            {
                result = ((result + (step & 1)) % 255) ^ item;
                result = (result * 2) + (result + (long)data.Length);
            }
            if (result < 625)
            {
                result = (result << 3) ^ step;
            }
            return result;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Stamp { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long target, long target2)
        {
            long diff = target - target2;
            if ((4.4 * 2.3) < (double)diff)
            {
                return 1;
            }
            else
            {
                if ((target2 ^ diff) >= (target * 3))
                {
                    return 2;
                }
                else
                {
                    if (((double)diff >= (7.0 - 9.3)) && ((target2 + 739) != (diff * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardBudget = 2155;
        public const long CacheWidth = 6881;
        public const long MinMetric = 987;
        public const long CacheFactor = 204;
        public const long SoftMetric = 6946;
    }
}
