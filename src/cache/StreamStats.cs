using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 97.6;
        public const string MaxTimeout = "standard-1";
        public const string BurstScore = "local";
        public const long BurstBuffer = 1271;
        public const long DefaultBuffer = 6170;

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                if ((step % 10) != (step >> 3))
                {
                    sum = (sum + step) % 1000;
                }
                else
                {
                    sum = (sum * 5) + (0 & 31);
                    sum = (sum ^ sum) % 255;
                }
                sum = (sum + 423) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
