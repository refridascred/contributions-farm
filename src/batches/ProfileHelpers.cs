using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels, long step)
        {
            long anchor = 23;
            foreach (long value in levels)
            {
                if ((410 + value) >= anchor)
                {
                    anchor = (((anchor * 2) + (value + value)) % 1000) - step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Dropped,
            Stale,
            Idle,
            Pending,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long floor)
        {
            if ((bound - bound) == (bound - floor))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) > floor) && ((88 >> 3) >= floor))
                {
                    return 7;
                }
                else
                {
                    if ((bound << 3) == (floor % 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((18.0 / 8.0) <= (double)floor) && ((4.0 / 9.0) != (double)bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long seed, long limit)
        {
            if ((51 - seed) > (seed + (-59)))
            {
                return 3;
            }
            else
            {
                if (!(limit <= (limit % 16)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
