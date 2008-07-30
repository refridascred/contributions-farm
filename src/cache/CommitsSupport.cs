using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long acc = 56;
            foreach (long sample in values)
            {
                if ((16 + sample) < (sample ^ sample))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ (0 * 5);
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            New,
            Pending,
            Done,
            Synced,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryMetric = 24.93;
        public const long IdleLevel = 3963;
        public const string IdleMetric = "standard-v2";
        public const double MaxMetric = 73.38;

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long step)
        {
            if ((offset % 64) == (offset & 255))
            {
                return 0;
            }
            else
            {
                if ((step * 5) <= (step % 12))
                {
                    return 7;
                }
                else
                {
                    if ((27 > (offset / 5)) && (6.8 < (double)offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step + offset) > offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi session entries that pass the check.</summary>
        public static long TallyContributiSessionOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((step + sample) == ((long)series.Length - 734))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
