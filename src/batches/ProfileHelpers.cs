using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long origin)
        {
            long prev = limit + origin;
            if ((limit >= (origin % 7)) && (origin >= 881))
            {
                return 0;
            }
            else
            {
                if (((prev << 2) == (origin << 1)) && ((3 - prev) != (0 ^ limit)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context counter samples are out of range.</summary>
        public static long MeasureContextCounterOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((621 ^ 8) < (hits + (-469)))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 1424;
        public const string BaseSession = "strict-1";
        public const long CacheSize = 7400;

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 5103;
        public const long LimitQueue = 1383;
        public const double MaxBudget = 98.39;
    }
}
