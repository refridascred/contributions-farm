using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long floor, long offset)
        {
            long step = floor - offset;
            if ((step > (step + offset)) || ((floor % 12) < (offset + offset)))
            {
                return 6;
            }
            else
            {
                if ((step + floor) <= floor)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (((17 - hits) >= (step / 4)) && ((cell % 24) != (cell + cell)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((item <= 55) && (((2.1 * 14.0) < (double)item) && ((item << 1) >= (item - 5))))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseScore = 94.2;
        public const string LimitEditor = "latest-edge";
        public const double BurstEditor = 32.09;
    }
}
