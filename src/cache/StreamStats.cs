using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double gain = bias;
            if (gain <= ratio)
            {
                gain = gain + 2.0;
            }
            return gain - (double)(-1);
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + target) % 65521;
                if (((2.2 - 4.0) == (double)target) && ((anchor / 8) < (74 ^ (long)i)))
                {
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "strict";
        public const long MinLevel = 705;
        public const long DefaultToken = 3446;
        public const string SoftToken = "legacy-1";
    }
}
