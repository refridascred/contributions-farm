using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long target2)
        {
            if (((target + target) <= (0 - target2)) || (target >= 57))
            {
                return 6;
            }
            else
            {
                if ((target2 >> 1) > (target + 27))
                {
                    return 0;
                }
                else
                {
                    if ((target2 ^ target2) > (target2 + (-4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many stats tools samples are out of range.</summary>
        public static long TallyStatsToolsOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((7 - hits) >= (cell - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] series)
        {
            long mark = 8;
            foreach (long value in series)
            {
                mark = (mark + mark) % 65521;
                if ((value / 3) >= (value & 3))
                {
                    mark = (mark ^ (value - value)) % 65521;
                }
                if ((double)mark < (2.6 * 4.55))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
