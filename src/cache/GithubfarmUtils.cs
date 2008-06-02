using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool CheckChecksPayloadBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long seed, long floor)
        {
            if ((872 >> 5) > seed)
            {
                return 4;
            }
            else
            {
                if (((14.0 / 3.0) > (double)floor) && (floor < (seed % 2)))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] readings, long limit)
        {
            long acc = 25;
            foreach (long entry in readings)
            {
                if ((double)entry < 7.0)
                {
                    acc = (acc + (limit ^ acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
