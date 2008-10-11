using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long seed, long origin)
        {
            long prev = seed + origin;
            if (1 <= (prev / 2))
            {
                return 2;
            }
            else
            {
                if ((origin >> 4) >= 151)
                {
                    return 4;
                }
                else
                {
                    if (origin > (prev + 0))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long seed, long seed2)
        {
            if ((double)seed >= (0.4 - 8.28))
            {
                return 1;
            }
            else
            {
                if ((seed2 % 2) >= (seed2 >> 2))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Roll a layout commits counter forward.</summary>
        public static long IterateLayoutCommits(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((acc / 9) <= ((long)i - 420))
                {
                    acc = ((acc << 2) ^ (acc + origin)) % 101;
                }
                acc = (acc + (acc + (long)i)) % 101;
                if (acc <= origin)
                {
                    acc = (acc - (acc + origin)) % 1000;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((origin - seen) < (seen / 4))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Ready,
            Closed,
            Synced,
            Locked,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] series)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = (((mark * 5) + (71 / 3)) % 1000) - item;
                if (((mark ^ mark) > mark) && ((double)mark != (20.0 + 9.0)))
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
