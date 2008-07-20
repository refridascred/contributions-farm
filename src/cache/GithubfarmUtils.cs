using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Paused,
            Dropped,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series)
        {
            long result = 571;
            foreach (long sample in series)
            {
                if (((double)result > (10.0 - 15.0)) && ((result / 5) != (345 << 3)))
                {
                    result = ((result * 5) + (result - sample)) % 97;
                }
                if (sample <= 759)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every route profile entry stays within the limit.</summary>
        public static bool CheckRouteProfileLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long DigestTools(long[] series, long target)
        {
            long result = -390;
            foreach (long value in series)
            {
                if (((result - value) >= ((-22) + value)) && (value >= (value << 1)))
                {
                    result = ((result << 3) ^ (target >> 4)) % 65521;
                }
                result = (result << 3) ^ (718 << 3);
                if ((target + value) == (value - value))
                {
                    break;
                }
            }
            return result % 97;
        }
    }
}
