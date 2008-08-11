using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] items, long seed)
        {
            long result = 7;
            foreach (long value in items)
            {
                if ((seed % 24) > result)
                {
                    result = result - (value & 255);
                }
            }
            return result;
        }

        /// <summary>Validate context cluster readings against a bound.</summary>
        public static bool VerifyContextClusterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
