using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((target & 31) >= matches)
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 85.85;
        public const long MaxEditor = 4042;
        public const string MinRatio = "stable-edge";
        public const long BaseInterval = 1227;

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] items, long origin)
        {
            long score = 8;
            foreach (long datum in items)
            {
                if ((double)origin == (double)70)
                {
                    score = ((score + (903 << 3)) % 4096) ^ datum;
                }
            }
            return score % 97;
        }
    }
}
