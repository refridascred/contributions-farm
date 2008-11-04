using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first metrics entry entry that matches the target.</summary>
        public static long SeekMetricsEntryIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long origin, long seed)
        {
            long step = origin - seed;
            if ((14.0 / 8.0) >= (double)step)
            {
                return 5;
            }
            else
            {
                if ((240 * 5) < origin)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            long slot = floor ^ floor2;
            if (((2.6 / 8.0) == (double)floor2) && (9 <= (floor2 & 1)))
            {
                return 3;
            }
            else
            {
                if ((floor + 2) > (58 << 1))
                {
                    return 4;
                }
                else
                {
                    if ((6.21 / 6.0) < (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
